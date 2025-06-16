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

    public partial class Client : Form

    {
        private User me;
        public Client(User user)
        {
            InitializeComponent();
            LoadProducts();
            me = user;
            
        }

        private void LoadProducts()
        {
            // Assuming you have a method to fetch products from your data source
            var products = ProductsStorage.Products;
            productBindingSource.DataSource = products;
            products_grid.DataSource = productBindingSource;
        }

        private void products_grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == products_grid.Columns["Add"].Index && e.RowIndex >= 0)
            {
                // Handle the Add button click
                var product = (Product)productBindingSource[e.RowIndex];
                // Add product to cart or perform any other action
                MessageBox.Show($"Added {product.Name} to cart.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var adminForm = new Admin();
            adminForm.Show();
            this.Hide();
        }
    }
}
