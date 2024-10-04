namespace Task_1
{
    public partial class Form1 : Form
    {
        private const string EMail = "Atilla@gmail.com";
        private const string Password = "Atilla@123";


        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Enter_Click(object sender, EventArgs e)
        {
            if (email.Text != EMail || password.Text != Password) MessageBox.Show("Username or password is wrong!!");
            else MessageBox.Show("Login was succesfully completed");
        }
    }
}
