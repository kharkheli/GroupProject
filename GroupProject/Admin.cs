namespace GroupProject
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button_login_Click(object sender, EventArgs e)
        {
            String email = input_email.Text;
            String password = input_password.Text;
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please All fields");
                return;
            }
            User? user = UserStorage.Login(email, password);
            if (user == null)
            {
                MessageBox.Show("Invalid email or password");
                return;
            }
            if(user.Role == "Client")
            {
                var clientForm = new Client(user);
                clientForm.Show();
                this.Hide();
            }

            if(user.Role == "Hr")
            {
                var hrForm = new hr(user);
                hrForm.Show();
                this.Hide();
            }

            if(user.Role == "Suplier")
            {
                var suplierForm = new Supplier(user);
                suplierForm.Show();
                this.Hide();
            }
        }

    }
}
