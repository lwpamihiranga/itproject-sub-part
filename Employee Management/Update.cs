using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
            if(txtUpdateLeftTime.Text == string.Empty)
            {
                a.EmployeeId = Int32.Parse(txtUpdateEmployeeId.Text);
                a.Date = dateTimePickerUpdate.Text;
                a.ArrivedTime = txtUpdateArrivedTime.Text;
            }
            else
            {
                a.EmployeeId = Int32.Parse(txtUpdateEmployeeId.Text);
                a.Date = dateTimePickerUpdate.Text;
                a.ArrivedTime = txtUpdateArrivedTime.Text;
                a.LeftTime = txtUpdateLeftTime.Text;
            }


            bool success = a.Update(a);
            
            if (success == true)
            {
                MessageBox.Show("Updated successfully");
            }
            else
            {
                MessageBox.Show("Unsucessful Update");
            }
           

           // if(txtUpdateArrivedTime.Text !="" && txtUpdateLeftTime.Text != "")
            //{
                //string inTime =txtUpdateArrivedTime.Text;
                //DateTime newInTime = DateTime.Parse(DateTime.Now.ToString("HH:mm ") + inTime);
                // DateTime newInTime = DateTime.ParseExact(inTime, "HH:mm",
                //                       CultureInfo.InvariantCulture);
               // this.Text = "00/00/0000 11:00";
                
                //DateTime time = DateTime.ParseExact(this.Text, "MM/dd/yyyy HH:mm",null);
                //string s = time.ToString("HH:mm");
                /*
                string outTime = txtUpdateLeftTime.Text;
                DateTime newOutTime = DateTime.ParseExact(outTime, "HH:mm",
                                       CultureInfo.InvariantCulture);
                
                var time = newOutTime.Subtract(newInTime);
                
                string differance = time.ToString();
                */
                //MessageBox.Show("Diffrance is" + s);
          //  }
          //  else
          //  {
          //      MessageBox.Show("Required fileds are not filled");
          //  }



            this.Hide();
        }

        private void Update_Load(object sender, EventArgs e)
        {
           
        }


    }
}
