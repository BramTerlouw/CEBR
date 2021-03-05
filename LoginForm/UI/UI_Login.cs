using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Service;

namespace UI
{
    public partial class UI_Login : Form
    {
        public UI_Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_Service login = new Login_Service();
            bool logSuccesFull = login.GetUser(txtUsername.Text, txtPassword.Text);
            
            
            if (logSuccesFull)
            {
                new UI_Page().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong username or password, please try again");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
