using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class UserStorage
{
    private static readonly string FilePath = "C:/Users/kalaboki/source/repos/GroupProject/GroupProject/data/users/users.json";
    private static List<User> _users;

    public static List<User> Users
    {
        get
        {
            if (_users == null)
            {
                _users = ReadUsers();
            }
            return _users;
        }
    }

    public static List<User> ReadUsers()
    {
        if (!File.Exists(FilePath))
            return new List<User>();

        string json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<User>>(json) ?? new List<User>();
    }

    public static void AddUser(User user)
    {
        Users.Add(user);
        WriteUsers();
    }

    public static void UpsertUser(User user)
    {
        
        if (user.Id is int)
        {
            UpdateUser(user);
        }
        else
        {
            int newId = Users.Count > 0 ? Users.Max(u => u.Id) + 1 : 1; // Generate new ID
            user.Id = newId;
            AddUser(user);
        }
        
    }

    public static void RemoveUser(User user)
    {
        Users.Remove(user);
        WriteUsers();
    }

    public static void UpdateUser(User user)
    {
        var existingUser = Users.Find(u => u.Id == user.Id);
        if (existingUser != null)
        {
            existingUser.Name = user.Name;
            existingUser.Email = user.Email;
            // Update other properties as needed
            WriteUsers();
        }
    }

    public static User[] GetClient()
    {
        return Users.Where(u => u.Role == "Client").ToArray();
    }

    public static User[] GetAdmin()
    {
         return Users.Where(u => u.Role == "Admin").ToArray();
    }

    public static void WriteUsers()
    {
        string json = JsonSerializer.Serialize(Users, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }

    public static User? Login(string email, string password)
    {
        return Users.Find(u => u.Email == email && u.Password == password);
    }
}