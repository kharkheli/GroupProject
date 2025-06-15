namespace GroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            header.Font = new Font("Arial", 20, FontStyle.Bold);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button_login_Click(object sender, EventArgs e)
        {
            String email = input_email.Text;
            MessageBox.Show("Email: " + email);
        }

        private void header_Click(object sender, EventArgs e)
        {

        }
    }
}
