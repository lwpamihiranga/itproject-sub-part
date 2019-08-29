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
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
        }

        AttendanceClass a = new AttendanceClass();
        private void Button1_Click(object sender, EventArgs e)
        {
            a.EmployeeId = Int32.Parse(txtUpdateEmployeeId.Text);
            a.Date = dateTimePickerUpdate.Text;
            a.ArrivedTime = int.Parse(txtUpdateArrivedTime.Text);
            a.LeftTime = int.Parse(txtUpdateLeftTime.Text);
            

            bool success = a.Update(a);
            if (success == true)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Unsucessful Update");
            }
            //this.Hide();
        }
    }
}
