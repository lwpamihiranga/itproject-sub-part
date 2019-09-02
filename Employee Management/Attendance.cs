using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Employee_Management
{
    public partial class Attendance : UserControl
    {
        public Attendance()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            AttendanceClass a = new AttendanceClass();
            if (e.ColumnIndex == dataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                //  MessageBox.Show("Edit button clicked and index is "+e.RowIndex);
                Update u = new Update();
                u.ShowDialog();
            }

            if (e.ColumnIndex == dataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int id = a.GetAttendId(e.RowIndex);



                bool success = a.Delete(id);
                if (success == true)
                {
                    MessageBox.Show("Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Cannot delete");
                }
            }

        }

        AttendanceClass a = new AttendanceClass();
        int Id = 0;
        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (txtEmployeeId.Text == string.Empty && txtArrivedTime.Text == string.Empty)
            {
                MessageBox.Show("Plaese fill the empty fields!");
            }
            else if (txtEmployeeId.Text == string.Empty)
            {                              
                 MessageBox.Show("Please enter an Employee Id!");
            }
            else if(txtArrivedTime.Text == string.Empty)
            {
                MessageBox.Show("Plaese enter the arrived time");

            }
            
            else if (!int.TryParse(txtEmployeeId.Text,out Id))
            {
                MessageBox.Show("Employee ID is invaid");
            }
           


                  
            

            else
            {

                a.EmployeeId = Int32.Parse(txtEmployeeId.Text);
                a.Date = dateTimePicker1.Text;
                a.ArrivedTime = txtArrivedTime.Text;
                // a.LeftTime = int.Parse(txtLeaftTime.Text);

                /* Type dataType = a.EmployeeId.GetType();
                 if (!dataType.Equals(typeof(int)))
                 {
                     MessageBox.Show("Invalid Employee Id");
                 }
                 */

                bool success = a.Insert(a);
                if (success == true)
                {
                    MessageBox.Show("Successfully inserted");
                }
                else
                {
                    MessageBox.Show("Cannot insert");
                }

                DataTable dt = a.Select();
                dataGridView.DataSource = dt;
            }
        }
        private void TabView_Click(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            dataGridView.DataSource = dt;
        }

        private void Attendance_Load_1(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            dataGridView.DataSource = dt;
        }

        private void BtnGenReport_Click(object sender, EventArgs e)
        {
            AttendanceReport report = new AttendanceReport();
            report.ShowDialog();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            //dataGridView.DataSource = null; DataTable dt = a.Select();
            DataTable dt = a.Select();
            dataGridView.DataSource = dt;

        }


        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        static string myConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(myConnectionString);
            int key = Int32.Parse(txtSearch.Text);
            string searchDate = dateTimePickerSearch.Text;

            SqlDataAdapter adapter1 = new SqlDataAdapter("SELECT EmpID,date,inTime,outTime FROM Attendance WHERE  EmpID=" + key + "AND date='" + searchDate + "'", conn);
            DataTable dt = new DataTable();
            adapter1.Fill(dt);
            dataGridView.DataSource = dt;
        }

        private void TxtEmployeeId_TextChanged(object sender, EventArgs e)
        {
           


        }

        /*public bool ValidEmployeeId(string EmployeeId, out string errorMessage)
        {
            // Confirm that the email address string is not empty.
            if (EmployeeId.Length == 0)
            {
                errorMessage = "email address is required.";
                return false;
            }
        }
        */
        private void TxtEmployeeId_Validating(object sender, CancelEventArgs e)
        {
           /* string errorMsg;
            if (!ValidEmployeeId(txtEmployeeId.Text, out errorMsg))
            {
                // Cancel the event and select the text to be corrected by the user.
                e.Cancel = true;
                txtEmployeeId.Select(0, txtEmployeeId.Text.Length);

                // Set the ErrorProvider error with the text to display. 
                this.errorProvider1.SetError(txtEmployeeId, errorMsg);
            }
            */
        }

        private void textBox1_Validated(object sender, System.EventArgs e)
        {
            // If all conditions have been met, clear the ErrorProvider of errors.
            //errorProvider1.SetError(txtEmployeeId, "");
        }

       

        private void BtnInsert_Validated(object sender, EventArgs e)
        {

        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            if (txtYear.Text == string.Empty)
            {
                MessageBox.Show("Plaese enter the year!");
            }
            else if(comboMonth.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a month!");
            }
        }
    }
}