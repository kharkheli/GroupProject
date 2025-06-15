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
        public hr()
        {
            InitializeComponent();

            string filePath = "C:/Users/kalaboki/source/repos/GroupProject/GroupProject/data/users/users.json";
            string jsonString = System.IO.File.ReadAllText(filePath);
            List<User> users = JsonSerializer.Deserialize<List<User>>(jsonString) ?? new List<User>();
            DataGridView grid = new DataGridView();
            grid.ColumnCount = 3;
            grid.Columns[0].Name = "ID";
            grid.Columns[1].Name = "Name";
            grid.Columns[2].Name = "Email";
            for(int i = 0; i < users.Count; i++)
            {
                grid.Rows.Add(users[i].Id, users[i].Name, users[i].Email);
            }
            //grid.Rows.Add("1", "Alice", "30");
            grid.Dock = DockStyle.Fill;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.Controls.Add(grid);
        }
    }
}
