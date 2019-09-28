using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Employee_Management
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void HomeUserControl_Load(object sender, EventArgs e)
        {
            Label.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
            System.Threading.Tasks.Task.Factory.StartNew(() =>
            {
                while(true)
                {
                    Thread.Sleep(1000);
                    this.Invoke(new Action(() =>
                       setDate()));
                }
               
            });



        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {

        }
        public void setDate()
        {
            Label.Text = DateTime.Now.ToString("dd-MMM-yyyy");
            label1.Text = DateTime.Now.ToString("hh:mm:ss tt");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
    }
}
