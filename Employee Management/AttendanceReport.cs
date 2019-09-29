using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Management
{
    public partial class AttendanceReport : Form
    {
        public AttendanceReport()
        {
            InitializeComponent();
        }

        AttendanceClass a = new AttendanceClass();
        private void AttendanceReport_Load(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            dataGridViewReport.DataSource = dt;

            
        }
        static string myConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        private void BtnSearchReport_Click(object sender, EventArgs e)
        {
           
           
                SqlConnection conn = new SqlConnection(myConnectionString);
                int key = Int32.Parse(txtSearchReport.Text);
                string searchDate = dateTimePickerSearchReport.Text;
            
                SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT EmpId,date,inTime,outTime FROM Attendance WHERE  EmpID=" + key + "AND date='" + searchDate + "'", conn);
                DataTable dt = new DataTable();
                adapter1.Fill(dt);
                dataGridViewReport.DataSource = dt;
            

              
            
        }

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            dataGridViewReport.DataSource = dt;
        }

        private void DataGridViewReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
