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
       

            foreach (DataRow row in dt.Rows)
            {
                string name = row["ReqID"].ToString();
                txtID.Text = row["EmpID"].ToString();

                dateTimePicker1.Text = "2018 / 09 / 05";

                txtHours.Text = row["LeaveHours"].ToString();
                txtDepartment.Text = row["Department"].ToString();
                txtDescription.Text = row["Description"].ToString();

            }

            

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string textID = txtID.Text;
                string date = dateTimePicker1.Text;
                int hours = int.Parse(txtHours.Text);
                string department = txtDepartment.Text;
                string desc = txtDescription.Text;

                if(dbhelper.update(RequestPortal.editRequestID,textID,date,department,desc,hours))
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
