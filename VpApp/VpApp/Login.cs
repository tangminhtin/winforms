using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VpApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginF();
        }

        private void LoginF()
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            if (user.Equals("tin") && pass.Equals("123"))
            {
                this.Hide();
                Main main = new Main();
                main.Show();
            }
            else
            {
                MessageBox.Show("Username or password incorrect!");
            }
        }

        private void txtPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                LoginF();
            }

            if (e.KeyChar == (char)Keys.F1)
            {
                Reset();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void Reset()
        {
            txtUser.Text = "";
            txtPass.Text = "";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SignUp().Show();
        }
    }
}
