using CRUD_Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Database
{
    public partial class Login : Form
    {
        DBAccess dB = new DBAccess();
        DataTable tblUsers = new DataTable();

        public static string id, name, email, password, country;

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUp signUp = new SignUp();
            signUp.Show();
        }

        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            email = txtEmail.Text;
            password = txtPassword.Text;
            string query = "SELECT * FROM Users WHERE Email='" + email + "' AND Password='" + password + "'";
            dB.readDatathroughAdapter(query, tblUsers);
            dB.closeConn();

            if (tblUsers.Rows.Count == 1)
            {
                id = tblUsers.Rows[0]["ID"].ToString();
                name = tblUsers.Rows[0]["Name"].ToString();
                country = tblUsers.Rows[0]["Country"].ToString();

                this.Hide();
                HomePage home = new HomePage();
                home.Show();
            } else
            {
                MessageBox.Show("Email or password incorrect");
            }
        }
    }
}
