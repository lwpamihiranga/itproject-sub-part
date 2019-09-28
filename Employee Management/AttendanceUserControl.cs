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
    public partial class AttendanceUserControl : UserControl
    {
        public AttendanceUserControl()
        {
            InitializeComponent();
        }

        private void AttendanceUserControl_Load(object sender, EventArgs e)
        {

        }

        private void DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            AttendanceClass a = new AttendanceClass();
            if (e.ColumnIndex == dataGridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                if (dataGridView.Rows.Count > 0)
                {
                    foreach (DataGridViewRow row in dataGridView.SelectedRows) // foreach datagridview selected rows values  
                    {
                        //txtAttend.Text = row.Cells[0].Value.ToString();
                        //txtEmployeeId.Text = row.Cells[1].Value.ToString();
                        //txtDate.Text = row.Cells[2].Value;
                        //txtArrivedTime.Text = row.Cells[3].Value.ToString();
                        //txtLeftTime.Text = row.Cells[4].Value.ToString();

                    }
                }
                /* int rowIndex = e.RowIndex;
                 string EmpId = dataGridView.Rows[rowIndex].Cells[1].Value.ToString(); ;
                 string date = dataGridView.Rows[rowIndex].Cells[2].Value.ToString(); ;
                 string ArrivedTime = dataGridView.Rows[rowIndex].Cells[3].Value.ToString();
                 */
                //UpdateForm u = new UpdateForm();
               // u.ShowDialog();

                //a.EmployeeId = Int32.Parse(u.txtUpdateEmployeeId.Text);
                // a.Date = dateTimePicker1.Text;
                a.ArrivedTime = lblArrivedTime.Text;



                bool success = a.Update(a);
                //  MessageBox.Show("Edit button clicked and index is "+e.RowIndex);
                if (success == true)
                {
                    MessageBox.Show("Updated successfully!");
                }
                else
                {
                    MessageBox.Show("Cannot update!");

                }



            }

            if (e.ColumnIndex == dataGridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {



                bool success = a.Delete(a);
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
            if (txtEmployeeId.Text == string.Empty
               //txtArrivedTime.Text == string.Empty
               )
            {
                MessageBox.Show("Plaese fill the empty fields!");
            }
            else if (txtEmployeeId.Text == string.Empty)
            {
                MessageBox.Show("Please enter an Employee Id!");
            }
            /*  else if(txtArrivedTime.Text == string.Empty)
              {
                  MessageBox.Show("Plaese enter the arrived time");

              }
              */
            else if (!int.TryParse(txtEmployeeId.Text, out Id))
            {
                MessageBox.Show("Employee ID is invaid");
            }






            else
            {

                a.EmployeeId = Int32.Parse(txtEmployeeId.Text);
                a.Date = dateTimePicker1.Text;

                lblInTime.Text = DateTime.Now.ToString("HH:mm");
                a.ArrivedTime = lblInTime.Text;
                //a.ArrivedTime = lblInTime.Text;
                // a.ArrivedTime = txtArrivedTime.Text;
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

        private void TabPage3_Click(object sender, EventArgs e)
        {

        }

        static string myConnectionString = ConfigurationManager.ConnectionStrings["connstrng"].ConnectionString;

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

        private void BtnViewAll_Click(object sender, EventArgs e)
        {
            DataTable dt = a.Select();
            dataGridView.DataSource = dt;
        }
    }
}
