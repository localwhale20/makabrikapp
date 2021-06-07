using System;
using System.Windows.Forms;

namespace MakabrikApp
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        AdminLogin adminLogin = new AdminLogin();
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminLogin.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            groupBox1.Visible = false;
            linkLabel2.Visible = false;
            button1.Visible = false;
            label3.Visible = false;
            pictureBox2.Visible = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            groupBox1.Visible = true;
            linkLabel2.Visible = true;
            button1.Visible = true;
            label3.Visible = true;
            pictureBox2.Visible = true;
        }

        About about = new About();
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            about.Show();
        }
    }
}
