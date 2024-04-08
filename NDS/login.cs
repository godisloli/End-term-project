using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NDS
{
    public partial class login : Form
    {
        string username = "admin";
        string password = "12345678";

        public login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainUI f = new mainUI();
            if (check(usernametxb.Text, passwordtxb.Text))
            {
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password","Error");
                usernametxb.Focus();
            }
        }

        bool check(string ten, string mk)
        {
            if (ten == this.username && mk == this.password)
                return true;
            return false;
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
