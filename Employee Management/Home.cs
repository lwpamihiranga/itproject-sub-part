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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
          
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

            pictureBox2.Image = Properties.Resources.admin;
            requestPortal1.Hide();

            

            attendanceUserControl1.Hide();

            attendanceUserControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
            homeUserControl1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);
            requestPortal1.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Bottom);


            pictureBox2.Anchor = (AnchorStyles.Top | AnchorStyles.Left );
            pictureBox1.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Bottom);

            this.MinimumSize = new System.Drawing.Size(1000, 550);






        }

        private void Button1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click_2(object sender, EventArgs e)
        {/*
            string it = ITNO.Text;
            sendRequest s = new sendRequest(it);


            if (s.insert(s))
            {
                MessageBox.Show("Request was sent succefully!");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
            DataTable dt = s.Select();
            gridView.DataSource = dt;*/
           

        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void PictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click_1(object sender, EventArgs e)
        {

        }

        private void Button3_Click_2(object sender, EventArgs e)
        {
            requestPortal1.Show();
            attendanceUserControl1.Hide();
            homeUserControl1.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            requestPortal1.Hide();
            homeUserControl1.Hide();
            attendanceUserControl1.Show();
        }

        private void RequestPortal1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            requestPortal1.Hide();
            attendanceUserControl1.Hide();
            homeUserControl1.Show();
        }

        private void HomeUserControl1_Load(object sender, EventArgs e)
        {
            
           
        }
    }
}
