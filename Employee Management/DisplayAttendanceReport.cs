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

        public static DataTable getReport;
        public DisplayAttendanceReport()
        {
            InitializeComponent();
        }
        
       
        private void DisplayAttendanceReport_Load(object sender, EventArgs e)
        {
            /* at.SortByID(sortID);
             DataTable dt = new DataTable();

             adapter2.Fill(dt);

             dataGridView.DataSource = dt;
           */
           if(AttendanceUserControl1.clickedSortType.Equals("EmpID"))
            {
                AttendanceClass a = new AttendanceClass();
                DataTable dts = a.SortByID(AttendanceUserControl1.sortID);
                dataGridView.DataSource = dts;
                getReport = dts;
            }
           else if(AttendanceUserControl1.clickedSortType.Equals("Date"))
            {
                AttendanceClass a = new AttendanceClass();
                DataTable dt = a.SortByDate(AttendanceUserControl1.date);
                dataGridView.DataSource = dt;
                getReport = dt;
            }
            

           
            
        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            if (getReport == null)
            {
                MessageBox.Show("Coudn't create report because the Dataset is Empty");
                return;
            }
            AttendanceClass reports = new AttendanceClass();
            if (reports.createPDF(getReport, "E:\\report\\report.pdf"))
            {
                MessageBox.Show("Report was saved ");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        
    }
    }
}
