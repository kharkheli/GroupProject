using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public static class ProductsStorage
{
    private static readonly string FilePath = "C:/Users/kalaboki/source/repos/GroupProject/GroupProject/data/products/products.json";
    private static List<Product> _products;

    public static List<Product> Products
    {
        get
        {
            if (_products == null)
            {
                _products = ReadProducts();
            }
            return _products;
        }
    }

    public static List<Product> ReadProducts()
    {
        if (!File.Exists(FilePath))
            return new List<Product>();
        string json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<Product>>(json) ?? new List<Product>();
    }



    public static void AddProduct(Product product)
    {
        Products.Add(product);
        WriteProducts();
    }

    public static void UpsertProduct(Product product)
    {
        if (product.Id > 0)
        {
            UpdateProduct(product);
        }
        else
        {
            int newId = Products.Count > 0 ? Products.Max(p => p.Id) + 1 : 1; // Generate new ID
            product.Id = newId;
            AddProduct(product);
        }
    }

    public static void RemoveProduct(Product product)
    {
        Products.Remove(product);
        WriteProducts();
    }

    public static void UpdateProduct(Product product)
    {
        var existingProduct = Products.Find(p => p.Id == product.Id);
        if (existingProduct != null)
        {
            existingProduct.Name = product.Name;
            existingProduct.Description = product.Description;
            existingProduct.Price = product.Price;
            existingProduct.StockQuantity = product.StockQuantity;
            WriteProducts();
        }
    }

    public static void WriteProducts()
    {
        string json = JsonSerializer.Serialize(Products, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }

    public static Product[] getMyProducts(User user)
    {
        return Products.Where(p => p.Suplier == user.Id).ToArray();
    }

    public static void UpdateStock(int id, int quantity)
    {
        var product = Products.Find(p => p.Id == id);
        if (product != null) { 
            product.StockQuantity = quantity;
            WriteProducts();
        }
    }
}