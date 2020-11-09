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
    public partial class BookingInfo : Form
    {
        public BookingInfo()
        {
            InitializeComponent();
        }

        private void BookingInfo_Load(object sender, EventArgs e)
        {
            lblName.Text = FlightBooking.firstname + FlightBooking.lastname;
            lblDeparture.Text = FlightBooking.from;
            lblDestination.Text = FlightBooking.to;
            lblTripDates.Text = FlightBooking.startTripDate + " to " + FlightBooking.endTripDate;
            lblPassportNo.Text = FlightBooking.documentNo;
            lblExpiryDate.Text = FlightBooking.expiryDate;
            lblWeight.Text = FlightBooking.weightBagg;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
