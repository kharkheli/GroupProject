namespace GroupProject
{
    partial class Supplier
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            products_grid = new DataGridView();
            idDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            descriptionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockQuantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            productBindingSource = new BindingSource(components);
            product_name = new TextBox();
            product_stock = new TextBox();
            product_description = new TextBox();
            product_price = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            save_buttom = new Button();
            log_out = new Button();
            ((System.ComponentModel.ISupportInitialize)products_grid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 13);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "suplier";
            // 
            // products_grid
            // 
            products_grid.AllowUserToAddRows = false;
            products_grid.AllowUserToDeleteRows = false;
            products_grid.AutoGenerateColumns = false;
            products_grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            products_grid.Columns.AddRange(new DataGridViewColumn[] { idDataGridViewTextBoxColumn, nameDataGridViewTextBoxColumn, descriptionDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, stockQuantityDataGridViewTextBoxColumn, Edit, Delete });
            products_grid.DataSource = productBindingSource;
            products_grid.Location = new Point(12, 250);
            products_grid.Name = "products_grid";
            products_grid.ReadOnly = true;
            products_grid.Size = new Size(776, 188);
            products_grid.TabIndex = 1;
            products_grid.CellContentClick += products_grid_CellContentClick;
            // 
            // idDataGridViewTextBoxColumn
            // 
            idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            idDataGridViewTextBoxColumn.HeaderText = "Id";
            idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Name";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // stockQuantityDataGridViewTextBoxColumn
            // 
            stockQuantityDataGridViewTextBoxColumn.DataPropertyName = "StockQuantity";
            stockQuantityDataGridViewTextBoxColumn.HeaderText = "StockQuantity";
            stockQuantityDataGridViewTextBoxColumn.Name = "stockQuantityDataGridViewTextBoxColumn";
            stockQuantityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            Edit.HeaderText = "Edit";
            Edit.Name = "Edit";
            Edit.ReadOnly = true;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.Name = "Delete";
            Delete.ReadOnly = true;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Product);
            // 
            // product_name
            // 
            product_name.Location = new Point(12, 87);
            product_name.Name = "product_name";
            product_name.Size = new Size(144, 23);
            product_name.TabIndex = 2;
            // 
            // product_stock
            // 
            product_stock.Location = new Point(343, 87);
            product_stock.Name = "product_stock";
            product_stock.Size = new Size(100, 23);
            product_stock.TabIndex = 3;
            product_stock.KeyPress += product_price_KeyPress;
            // 
            // product_description
            // 
            product_description.Location = new Point(12, 146);
            product_description.Multiline = true;
            product_description.Name = "product_description";
            product_description.Size = new Size(732, 23);
            product_description.TabIndex = 4;
            // 
            // product_price
            // 
            product_price.Location = new Point(181, 87);
            product_price.Name = "product_price";
            product_price.Size = new Size(116, 23);
            product_price.TabIndex = 5;
            product_price.KeyPress += product_price_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 61);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 6;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(181, 61);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 7;
            label3.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(347, 61);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 8;
            label4.Text = "Stock Quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 122);
            label5.Name = "label5";
            label5.Size = new Size(67, 15);
            label5.TabIndex = 9;
            label5.Text = "Description";
            // 
            // save_buttom
            // 
            save_buttom.Location = new Point(12, 194);
            save_buttom.Name = "save_buttom";
            save_buttom.Size = new Size(75, 23);
            save_buttom.TabIndex = 10;
            save_buttom.Text = "Save";
            save_buttom.UseVisualStyleBackColor = true;
            save_buttom.Click += save_buttom_Click;
            // 
            // log_out
            // 
            log_out.Location = new Point(704, 9);
            log_out.Name = "log_out";
            log_out.Size = new Size(75, 23);
            log_out.TabIndex = 11;
            log_out.Text = "Log Out";
            log_out.UseVisualStyleBackColor = true;
            log_out.Click += log_out_Click;
            // 
            // Supplier
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(log_out);
            Controls.Add(save_buttom);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(product_price);
            Controls.Add(product_description);
            Controls.Add(product_stock);
            Controls.Add(product_name);
            Controls.Add(products_grid);
            Controls.Add(label1);
            Name = "Supplier";
            Text = "Form1";
            KeyPress += Supplier_KeyPress;
            ((System.ComponentModel.ISupportInitialize)products_grid).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView products_grid;
        private DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stockQuantityDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private BindingSource productBindingSource;
        private TextBox product_name;
        private TextBox product_stock;
        private TextBox product_description;
        private TextBox product_price;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button save_buttom;
        private Button log_out;
    }
}