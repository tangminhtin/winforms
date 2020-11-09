using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class Main : Form
    {
        DataTable dtCourse = new DataTable();
        DataTable dtSelectedCourse = new DataTable();
        private void FillDataCourseTable()
        {
            dtCourse.Columns.Add("ID", typeof(int));
            dtCourse.Columns.Add("Name");
            dtCourse.Columns.Add("Duration");

            dtCourse.Rows.Add(1, "Java", "6 months");
            dtCourse.Rows.Add(2, "PHP", "4 months");
            dtCourse.Rows.Add(3, "C#", "2 months");
            dtCourse.Rows.Add(4, "JSP", "3 months");
            dtCourse.Rows.Add(5, "C", "5 months");
        }
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            FillDataCourseTable();
            SelectedCourseTable();
            lstData.DataSource = dtCourse;
            lstData.DisplayMember = "Name";

            lstNew.DataSource = dtSelectedCourse;
            lstNew.DisplayMember = "Name";
        }

        private void SelectedCourseTable()
        {
            dtSelectedCourse.Columns.Add("ID", typeof(int));
            dtSelectedCourse.Columns.Add("Name");
            dtSelectedCourse.Columns.Add("Duration");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(lstData.Items.Count > 0)
            {
                dtSelectedCourse.ImportRow(dtCourse.Rows[lstData.SelectedIndex]);
                dtCourse.Rows[lstData.SelectedIndex].Delete();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if(lstNew.Items.Count > 0)
            {
                dtCourse.ImportRow(dtSelectedCourse.Rows[lstNew.SelectedIndex]);
                dtSelectedCourse.Rows[lstNew.SelectedIndex].Delete();
            }
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            int count = dtCourse.Rows.Count;
            for(int i=count-1; i >= 0; i--)
            {
                dtSelectedCourse.ImportRow(dtCourse.Rows[lstData.SelectedIndex]);
                dtCourse.Rows[lstData.SelectedIndex].Delete();
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            int count = dtSelectedCourse.Rows.Count;
            for(int i=count-1; i>=0; i--)
            {
                dtCourse.ImportRow(dtSelectedCourse.Rows[lstNew.SelectedIndex]);
                dtSelectedCourse.Rows[lstNew.SelectedIndex].Delete();
            }
        }

        private void btnFinalize_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Are you sure you want o finalize the selected courses", "Confirm message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                gvCourses.DataSource = dtSelectedCourse;
                gvCourses.Enabled = false;
                gvCourses.Columns[0].Visible = false;
                gvCourses.RowHeadersVisible = false;
                gvCourses.Columns[1].Width = 200;
                gvCourses.Columns[2].Width = 200;
            } else
            {
                MessageBox.Show("Please select at least one coures.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
