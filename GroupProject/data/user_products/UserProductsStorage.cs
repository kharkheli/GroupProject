using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

public static class UserProductsStorage
{
    private static readonly string FilePath = "C:/Users/kalaboki/source/repos/GroupProject/GroupProject/data/user_products/user_products.json";
    private static List<UserProducts> _products;

    public static List<UserProducts> Products
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

    public static List<UserProducts> ReadProducts()
    {
        if (!File.Exists(FilePath))
            return new List<UserProducts>();
        string json = File.ReadAllText(FilePath);
        return JsonSerializer.Deserialize<List<UserProducts>>(json) ?? new List<UserProducts>();
    }

    public static void WriteProducts()
    {
        string json = JsonSerializer.Serialize(Products, new JsonSerializerOptions { WriteIndented = true });
        File.WriteAllText(FilePath, json);
    }



    public static void UpsertToCart(UserProducts product)
    {
        if(product.RecordId >= 0)
        {
            var existingProduct = Products.Find(p => p.RecordId == product.RecordId);
            if (existingProduct != null) { 

                existingProduct.Quantity = product.Quantity;
            }

        }
        else
        {
            Products.Add(product);
            ProductsStorage.UpdateStock(product.Id, product.StockQuantity - product.Quantity);
        }
            
        WriteProducts();
    }

    public static UserProducts[] GetProducts(User user)
    {
        return Products.Where(p => p.UserID == user.Id).ToArray();
    }

    public static UserProducts[] GetProductsSuplier(User user) {
        return Products.Where(p => p.Suplier == user.Id && p.State == "Sold").ToArray();
    }
    

}
