using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using System.Text.Json;

namespace GroupProject
{

    public partial class hr : Form
    {
        public User ActiveUser { get; set; } = new User();
        public User me;
        public hr(User user)
        {
            InitializeComponent();


            hr_load();
            this.me = user;
        }

        private void hr_load()
        {
            var users = UserStorage.Users;
            UsersGrid.DataSource = new BindingList<User>(users);

        }


        private void UsersGrid_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            var grid = sender as DataGridView;
            if (grid.IsCurrentCellDirty)
            {
                grid.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void UsersGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == UsersGrid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                // Handle the delete button click
                var user = UserStorage.Users[e.RowIndex];
                UserStorage.RemoveUser(user);
                hr_load(); // Reload the grid to reflect changes
                return;
            }
            if (e.ColumnIndex == UsersGrid.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                // Handle the edit button click
                ActiveUser = UserStorage.Users[e.RowIndex] as User;
                input_name.Text = ActiveUser.Name;
                input_email.Text = ActiveUser.Email;
                input_password.Text = ActiveUser.Password;
                input_role.Text = ActiveUser.Role;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ActiveUser.Name = input_name.Text;
        }


        private void inputName_TextChanged(object sender, EventArgs e)
        {
            ActiveUser.Email = input_email.Text;
        }

        private void input_password_TextChanged(object sender, EventArgs e)
        {
            ActiveUser.Password = input_password.Text;
        }

        private void input_role_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActiveUser.Role = input_role.SelectedItem.ToString();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(ActiveUser.Name) ||
                string.IsNullOrWhiteSpace(ActiveUser.Email) ||
                string.IsNullOrWhiteSpace(ActiveUser.Role) ||
                string.IsNullOrWhiteSpace(ActiveUser.Password))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            UserStorage.UpsertUser(ActiveUser);
            ActiveUser = new User(); // Reset ActiveUser for next entry
            input_name.Clear();
            input_email.Clear();
            input_password.Clear();
            input_role.Text = string.Empty;
            hr_load(); // Reload the grid to reflect changes


            // All fields are set, proceed with saving logic
            // ...
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adminForm = new Admin();
            adminForm.Show();
            this.Hide();
        }
    }
}
