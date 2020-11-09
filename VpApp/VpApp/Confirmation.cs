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
    public partial class Confirmation : Form
    {
        public Confirmation()
        {
            InitializeComponent();
        }

        private void Confirmation_Load(object sender, EventArgs e)
        {
            lblFirst.Text = SignUp.first;
            lblLast.Text = SignUp.last;
            lblEmail.Text = SignUp.email;
            lblSMS.Text = SignUp.SMS ? "/" : "x";
            lblReport.Text = SignUp.report ? "/" : "x";
            lblTransaction.Text = SignUp.transaction ? "/" : "x";
            lblKill.Text = "Skill: " + SignUp.rad;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();
        }
    }
}
