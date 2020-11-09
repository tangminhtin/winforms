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
    public partial class SignUp : Form
    {
        public static string first;
        public static string last;
        public static string email;
        public static bool SMS;
        public static bool report;
        public static bool transaction;
        public static string rad;
        Confirmation confirmation = new Confirmation();

        public SignUp()
        {
            InitializeComponent();
        }

        private void chkSMS_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSMS.Checked)
            {
                lblSMS.Text = "checked";
            } else
            {
                lblSMS.Text = "";
            }
        }

        private void chkReport_CheckedChanged(object sender, EventArgs e)
        {
            if (chkReport.Checked)
            {
                lblReport.Text = "checked";
            }
            else
            {
                lblReport.Text = "";
            }
        }

        private void chkTransaction_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTransaction.Checked)
            {
                lblTransaction.Text = "checked";
            }
            else
            {
                lblTransaction.Text = "";
            }
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            first = txtFirstname.Text;
            last = txtLastname.Text;
            email = txtEmail.Text;
            SMS = chkSMS.Checked;
            report = chkReport.Checked;
            transaction = chkTransaction.Checked;

            if (radBad.Checked)
            {
                rad = radBad.Text;
            }
            
            if (radNormal.Checked)
            {
                rad = radNormal.Text;
            }

            if (radGood.Checked)
            {
                rad = radGood.Text;
            }

            this.Hide();
            confirmation.Show();
        }
    }
}
