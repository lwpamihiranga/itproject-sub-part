using Employee_Management.Classes;
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
    public partial class EditRequestPopupWindow : Form
    {

        DatabaseHelper dbhelper = new DatabaseHelper();
        public EditRequestPopupWindow()
        {
            InitializeComponent();
        }

        private void EditRequestPopupWindow_Load(object sender, EventArgs e)
        {
            
             int id = RequestPortal.editRequestID;
             DataTable dt = dbhelper.getRequestDetails(id);
             dateTimePicker1.MinDate = DateTime.Today;


            foreach (DataRow row in dt.Rows)
            {

                try
                {
                    string name = row["ReqID"].ToString();
                    txtID.Text = row["EmpID"].ToString();
                    txtHours.Text = row["LeaveHours"].ToString();
                    txtDepartment.Text = row["Department"].ToString();
                    txtDescription.Text = row["Description"].ToString();

                    DateTime oDate = Convert.ToDateTime(row["Date"].ToString());

                    DateTime a = oDate.Date;



                    dateTimePicker1.Value = a;

                }
                catch(Exception edada)
                {

                }


            }

            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string textID = txtID.Text;
                string date = dateTimePicker1.Text;
                int hours = 0;
                try
                {
                    hours = int.Parse(txtHours.Text);
                }
                catch(Exception ess)
                {
                    MessageBox.Show("Enter a Numeric value for Hours");
                    return;
                }
                
                
                string department = txtDepartment.Text;
                string desc = txtDescription.Text;


                if(textID.Equals("") || textID == null)
                {
                    MessageBox.Show("Enter a ID");
                    return;
                }
                if (desc == null || desc.Equals(""))
                {
                    MessageBox.Show("Enter a Description");
                    return;
                }
                if (department == null || department.Equals(""))
                {
                    MessageBox.Show("Enter a Department");
                    return;
                }


                if (dbhelper.update(RequestPortal.editRequestID,textID,date,department,desc,hours))
                {
                    MessageBox.Show("Updated");
                    this.Hide();
      
                }
                else
                {
                    MessageBox.Show("Could not Updated");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter Details Properly!");
            }
            
        }
    }
}
