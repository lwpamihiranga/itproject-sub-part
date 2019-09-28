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
    public partial class UpdateAttendance : Form
    {
        public UpdateAttendance()
        {
            InitializeComponent();
        }

        AttendanceClass a = new AttendanceClass();
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

           // int id = AttendanceUserControl.ID;
            //DataTable dt = a.Select();

            try
            {
                a.EmployeeId = Int32.Parse(txtUpdateEmpID.Text);
            }
            catch (Exception esd)
            {
                MessageBox.Show("Enter a numeric value");
                return;
            }
            
            a.Date = dateTimePickerUpdate.Text;
            a.ArrivedTime = lblInTime.Text;
            lblLeftTime.Text = DateTime.Now.ToString("HH:mm");
            a.LeftTime = lblLeftTime.Text;



            bool success = a.Update(a,AttendanceUserControl.ID);

            if (success == true)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Unsucessful Update");
            }
            this.Hide();

        }

        private void UpdateAttendance_Load(object sender, EventArgs e)
        {
            lblOutTime.Text = DateTime.Now.ToString("HH:mm");
            a.ArrivedTime = lblOutTime.Text;

            AttendanceClass cl = new AttendanceClass();
            DataTable dt = cl.SelectByID(AttendanceUserControl.ID);

            foreach (DataRow row in dt.Rows)
            {
                txtUpdateEmpID.Text = row["EmpID"].ToString();
                lblInTime.Text = row["inTime"].ToString();
                lblLeftTime.Text = row["outTime"].ToString();
                dateTimePickerUpdate.Text = row["date"].ToString();

            }

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
