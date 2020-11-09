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
    public partial class HomePage : Form
    {
        DBAccess dB = new DBAccess();
        DataTable dataUsers = new DataTable();
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            lblName.Text = Login.name;
            txtName.Text = Login.name;
            txtEmail.Text = Login.email;
            txtPassword.Text = Login.password;
            cmbCountry.Text = Login.country;

            string query = "SELECT * FROM Users";
            dB.readDatathroughAdapter(query, dataUsers);
            gvUser.DataSource = dataUsers;
            gvUser.RowHeadersVisible = false;
            gvUser.Columns[0].Width = 30;
            gvUser.AutoResizeRows();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommand update = new SqlCommand("UPDATE Users SET Name='" + txtName.Text + "', Email='" + txtEmail.Text + "', Password='" + txtPassword.Text + "', Country='" + cmbCountry.Text + "' WHERE ID='" + Login.id + "'"); ;
            int row = dB.excuteQuery(update);
            if (row == 1)
            {
                MessageBox.Show("Update successfull!");
            } else
            {
                MessageBox.Show("Update fail!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you want to delete?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                int row = dB.excuteQuery(new SqlCommand("DELETE FROM Users WHERE ID='" + Login.id + "'"));
                if (row == 1)
                {
                    MessageBox.Show("Delete Successfull");
                } else
                {
                    MessageBox.Show("Delete Fail");
                }
            }

        }

        private void btnAction_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM Users";
            int changes = dB.excuteDataAdapter(dataUsers, query);
            MessageBox.Show("count = " + changes);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
