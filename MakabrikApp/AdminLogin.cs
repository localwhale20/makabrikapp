using System;
using System.Windows.Forms;

namespace MakabrikApp
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // registering components
            bool username;
            bool password;
            // making username check
            if (textBox2.Text == "danilwhale")
            {
                // if username correct
                username = true;
            }
            else
            {
                // if username NOT correct
                username = false;
            }
            // making password check
            if (textBox1.Text == "makabrikapp070621")
            {
                // if password correct
                password = true;
            }
            else
            {
                // if password NOT correct
                password = false;
            }
            bool correct = username & password;
            AdminMain adminPanel = new AdminMain();
            LoginError loginError = new LoginError();
            if (correct == true)
            {
                adminPanel.ShowDialog();
                this.Close();
            }
            else
            {
                loginError.Show();
                this.Close();
            }
        }
    }
}
