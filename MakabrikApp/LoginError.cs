using System;
using System.Windows.Forms;

namespace MakabrikApp
{
    public partial class LoginError : Form
    {
        public LoginError()
        {
            InitializeComponent();
        }
        AdminLogin adminLogin = new AdminLogin();
        private void button1_Click(object sender, EventArgs e)
        {
            adminLogin.Show();
            this.Close();
        }
    }
}
