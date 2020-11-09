using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightBooking
{
    public partial class FlightBooking : Form
    {
        public static bool passport, idCard;
        public static string weightBagg, documentNo, issueDate, expiryDate, startTripDate, endTripDate, to, from, firstname, lastname;

        private void dtPickerIssue_ValueChanged(object sender, EventArgs e)
        {
            DateTime dt = dtPickerIssue.Value;
            dtPickerExpiry.MinDate = dt;
        }

        public FlightBooking()
        {
            InitializeComponent();
        }

        private void radPassport_CheckedChanged(object sender, EventArgs e)
        {
            if (radPassport.Checked)
            {
                lblDocumentNo.Text = "Passport no:";
                lblIssue.Text = "Passport issue date:";
                lblExpiry.Text = "Passport expiry date:";
                passport = true;
            }
        }

        private void radIDCard_CheckedChanged(object sender, EventArgs e)
        {
            if (radIDCard.Checked)
            {
                lblDocumentNo.Text = "ID Card no:";
                lblIssue.Text = "ID Card issue date:";
                lblExpiry.Text = "ID Card expiry date:";
                idCard = true;
            }

        }

        private void btnBooking_Click(object sender, EventArgs e)
        {
            to = txtTo.Text;
            from = txtFrom.Text;

            startTripDate = monthCalendar.SelectionStart.ToString("dd MM yyyy");
            endTripDate = monthCalendar.SelectionEnd.ToString("dd MM yyyy");

            firstname = txtFirstname.Text;
            lastname = txtLastname.Text;
            documentNo = txtDocumentNo.Text;

            issueDate = dtPickerIssue.Value.ToString("dd MM yyyy");
            expiryDate = dtPickerExpiry.Value.ToString("dd MM yyyy");
            weightBagg = numBaggage.Value.ToString();

            this.Hide();
            new BookingInfo().Show();
        }

        private void FlightBooking_Load(object sender, EventArgs e)
        {
            monthCalendar.MaxSelectionCount = 100;
            monthCalendar.ShowToday = true;
            
            numBaggage.Increment = 5;
            numBaggage.ReadOnly = true;
        }
    }
}
