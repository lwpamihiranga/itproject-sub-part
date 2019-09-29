using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class DisplayAttendanceReport : Form
    {
        public DisplayAttendanceReport()
        {
            InitializeComponent();
        }
        AttendanceClass a = new AttendanceClass();
        AttendanceUserControl1 attend = new AttendanceUserControl1();
        private void DisplayAttendanceReport_Load(object sender, EventArgs e)
        {

            DataTable dt = a.SortByID(attend.sortID);
            dataGridView.DataSource = dt;
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
