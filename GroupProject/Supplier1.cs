using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Supplier1 : Form
    {
        private User me;
        private int ProductId;
        public Supplier(User user)
        {
            InitializeComponent();
            me = user;
            LoadProducts();
        }

        private void LoadProducts()
        {
            if (me == null)
            {
                MessageBox.Show("unauthorized");
                return;
            }
            Product[] products = ProductsStorage.getMyProducts(me);
            products_grid.DataSource = products;

        }

        private void product_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Supplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void save_buttom_Click(object sender, EventArgs e)
        {
            string name = product_name.Text;
            int price = int.Parse(product_price.Text);
            int stock = int.Parse(product_stock.Text);
            string description = product_description.Text;

            if (string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(product_price.Text)
                || string.IsNullOrEmpty(product_stock.Text)
                || string.IsNullOrEmpty(description))
            {
                MessageBox.Show("please fill all the fields");
                return;
            }

            var product = new Product();
            product.Name = name;
            product.Price = price;
            product.Suplier = me.Id;
            product.StockQuantity = stock;
            if (ProductId >= 0)
            {
                product.Id = ProductId;
            }
            product.Description = description;
            ProductsStorage.UpsertProduct(product);
            LoadProducts();
            ProductId = -1;
            product_name.Text = "";
            product_price.Text = "";
            product_description.Text = "";
            product_stock.Text = "";


        }

        private void products_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == products_grid.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                var product = ProductsStorage.getMyProducts(me)[e.RowIndex];
                ProductId = product.Id;
                product_name.Text = product.Name;
                product_price.Text = product.Price + "";
                product_description.Text = product.Description;
                product_stock.Text = product.StockQuantity + "";
            }
            if (e.ColumnIndex == products_grid.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                Product product = ProductsStorage.getMyProducts(me)[e.RowIndex];
                ProductsStorage.RemoveProduct(product);
                LoadProducts();
            }
        }

        private void log_out_Click(object sender, EventArgs e)
        {
            var adminForm = new Admin();
            adminForm.Show();
            this.Hide();
        }
    }
}
