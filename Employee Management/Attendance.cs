using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Update u = new Update();
            u.ShowDialog();
        }

        AttendanceClass a = new AttendanceClass();

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            a.EmployeeId = Int32.Parse(txtEmployeeId.Text);
            a.Date = dateTimePicker1.Text;
            a.ArrivedTime = int.Parse(txtArrivedTime.Text);
           // a.LeftTime = int.Parse(txtLeavingTime.Text);

            bool sucess = a.Insert(a);
            if (sucess == true)
            {
                MessageBox.Show("Insertion successful");
            }
            else
            {
                MessageBox.Show("Insertion unsucessful");
            }
        }
    }
}
