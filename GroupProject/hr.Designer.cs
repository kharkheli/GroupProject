namespace GroupProject
{
    partial class hr
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
            UsersGrid = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Role = new DataGridViewComboBoxColumn();
            Password = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewImageColumn();
            input_name = new TextBox();
            input_email = new TextBox();
            input_password = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            save_button = new Button();
            input_role = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)UsersGrid).BeginInit();
            SuspendLayout();
            // 
            // UsersGrid
            // 
            UsersGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UsersGrid.Columns.AddRange(new DataGridViewColumn[] { ID, NameColumn, Email, Role, Password, Column1 });
            UsersGrid.Location = new Point(12, 250);
            UsersGrid.Name = "UsersGrid";
            UsersGrid.Size = new Size(734, 150);
            UsersGrid.TabIndex = 0;
            UsersGrid.CellContentClick += UsersGrid_CellContentClick;
            // 
            // ID
            // 
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            NameColumn.ReadOnly = true;
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            Email.ReadOnly = true;
            // 
            // Role
            // 
            Role.HeaderText = "Role";
            Role.Items.AddRange(new object[] { "Admin", "Client", "Hr", "Supplier" });
            Role.Name = "Role";
            Role.ReadOnly = true;
            // 
            // Password
            // 
            Password.HeaderText = "Password";
            Password.Name = "Password";
            Password.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Edit";
            Column1.Name = "Column1";
            // 
            // input_name
            // 
            input_name.Location = new Point(12, 58);
            input_name.Name = "input_name";
            input_name.Size = new Size(303, 23);
            input_name.TabIndex = 1;
            input_name.TextChanged += textBox1_TextChanged;
            // 
            // input_email
            // 
            input_email.Location = new Point(12, 118);
            input_email.Name = "input_email";
            input_email.Size = new Size(303, 23);
            input_email.TabIndex = 2;
            input_email.TextChanged += inputName_TextChanged;
            // 
            // input_password
            // 
            input_password.Location = new Point(373, 118);
            input_password.Name = "input_password";
            input_password.Size = new Size(342, 23);
            input_password.TabIndex = 4;
            input_password.TextChanged += input_password_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 33);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 5;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(373, 33);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(30, 15);
            label2.TabIndex = 6;
            label2.Text = "Role";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 100);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 7;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(373, 100);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Password";
            // 
            // save_button
            // 
            save_button.Location = new Point(13, 170);
            save_button.Name = "save_button";
            save_button.Size = new Size(75, 23);
            save_button.TabIndex = 9;
            save_button.Text = "Save";
            save_button.UseVisualStyleBackColor = true;
            save_button.Click += save_button_Click;
            // 
            // input_role
            // 
            input_role.AutoCompleteCustomSource.AddRange(new string[] { "Hr", "Client", "Suplier" });
            input_role.FormattingEnabled = true;
            input_role.Items.AddRange(new object[] { "Hr", "Client", "Supplier" });
            input_role.Location = new Point(373, 63);
            input_role.Name = "input_role";
            input_role.Size = new Size(342, 23);
            input_role.TabIndex = 10;
            input_role.SelectedIndexChanged += input_role_SelectedIndexChanged;
            // 
            // hr
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(input_role);
            Controls.Add(save_button);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(input_password);
            Controls.Add(input_email);
            Controls.Add(input_name);
            Controls.Add(UsersGrid);
            Name = "hr";
            Text = "Hr";
            ((System.ComponentModel.ISupportInitialize)UsersGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView UsersGrid;
        private TextBox input_name;
        private TextBox input_email;
        private TextBox input_password;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button save_button;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewComboBoxColumn Role;
        private DataGridViewTextBoxColumn Password;
        private DataGridViewImageColumn Column1;
        private ComboBox input_role;
    }
}