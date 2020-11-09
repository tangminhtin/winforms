using CRUD_Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Database
{
    public partial class SignUp : Form
    {
        DBAccess dB = new DBAccess();
        public SignUp()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;
            string email = txtEmail.Text;
            string country = cmbCountry.Text;

            SqlCommand insertCmd = new SqlCommand("INSERT INTO Users(Name, Email, Password, Country) VALUES (@username, @email, @password, @country)");
            insertCmd.Parameters.AddWithValue("@username", username);
            insertCmd.Parameters.AddWithValue("@password", password);
            insertCmd.Parameters.AddWithValue("@country", country);
            insertCmd.Parameters.AddWithValue("@email", email);

            int row = dB.excuteQuery(insertCmd);
            if (row == 10)
            {
                MessageBox.Show("Account Created Successfully.");
                this.Hide();
            } else
            {
                MessageBox.Show("Error Occured. Try Again.");
            }
        }
    }
}
