namespace GroupProject
{
    partial class Admin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            header = new Label();
            input_email = new TextBox();
            colorDialog1 = new ColorDialog();
            label_email = new Label();
            label_password = new Label();
            input_password = new TextBox();
            button_login = new Button();
            SuspendLayout();
            // 
            // header
            // 
            header.AutoSize = true;
            header.Location = new Point(281, 23);
            header.Name = "header";
            header.Size = new Size(65, 15);
            header.TabIndex = 0;
            header.Text = "Avtorizacia";
            header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input_email
            // 
            input_email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            input_email.BackColor = SystemColors.Window;
            input_email.Location = new Point(272, 101);
            input_email.Name = "input_email";
            input_email.Size = new Size(223, 23);
            input_email.TabIndex = 1;
            // 
            // label_email
            // 
            label_email.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label_email.AutoSize = true;
            label_email.Location = new Point(272, 66);
            label_email.Name = "label_email";
            label_email.Size = new Size(53, 15);
            label_email.TabIndex = 2;
            label_email.Text = "ემეილი";
            // 
            // label_password
            // 
            label_password.AutoSize = true;
            label_password.Location = new Point(272, 143);
            label_password.Name = "label_password";
            label_password.Size = new Size(57, 15);
            label_password.TabIndex = 3;
            label_password.Text = "პაროლი";
            // 
            // input_password
            // 
            input_password.Location = new Point(272, 172);
            input_password.Name = "input_password";
            input_password.Size = new Size(223, 23);
            input_password.TabIndex = 4;
            // 
            // button_login
            // 
            button_login.Location = new Point(353, 224);
            button_login.Name = "button_login";
            button_login.Size = new Size(75, 23);
            button_login.TabIndex = 5;
            button_login.Text = "avtorizacia";
            button_login.UseVisualStyleBackColor = true;
            button_login.Click += button_login_Click;
            // 
            // Admin
            // 
            AcceptButton = button_login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            ClientSize = new Size(800, 450);
            Controls.Add(button_login);
            Controls.Add(input_password);
            Controls.Add(label_password);
            Controls.Add(label_email);
            Controls.Add(input_email);
            Controls.Add(header);
            ForeColor = Color.Black;
            Name = "Admin";
            Text = "Admin";
            TransparencyKey = Color.Black;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label header;
        private TextBox input_email;
        private ColorDialog colorDialog1;
        private Label label_email;
        private Label label_password;
        private TextBox input_password;
        private Button button_login;
    }
}
