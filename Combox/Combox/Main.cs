using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Combox
{
    public partial class Main : Form
    {
        DataTable dtProvice = new DataTable();
        private void FillProviceTable()
        {
            dtProvice.Columns.Add("ID", typeof(int));
            dtProvice.Columns.Add("Name");
            dtProvice.Columns.Add("Rating");

            dtProvice.Rows.Add(1, "Tien Giang", "3/5");
            dtProvice.Rows.Add(2, "Hau Giang", "4/5");
            dtProvice.Rows.Add(3, "An Giang", "2/5");
            dtProvice.Rows.Add(4, "Kien Giang", "3/5");
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillProviceTable();
            cmbProvice.DataSource = dtProvice;
            cmbProvice.DisplayMember = "Name";
        }

        private void cmbProvice_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSelectProvice.Text = "Provice: " + dtProvice.Rows[cmbProvice.SelectedIndex]["Name"].ToString() + "\nRating: " + dtProvice.Rows[cmbProvice.SelectedIndex]["Rating"].ToString();
        }
    }
}
