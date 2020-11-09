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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Login().Show();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            lblContent.Text = "New content to be set";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lblContent.Text = "Content was cancel!";
        }

        private void dtPicker_ValueChanged(object sender, EventArgs e)
        {
            lblDate1.Text = dtPicker.Value.ToString("dd/MM/yyyy");
            lblDate2.Text = dtPicker.Value.ToLongDateString();
            lblDate3.Text = dtPicker.Value.ToLongTimeString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to exit?", "Confirm exit application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
