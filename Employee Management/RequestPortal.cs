using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Management.Classes;

namespace Employee_Management
{
    
    public partial class RequestPortal : UserControl
    {
        static int numberOfRows = 0;
        public static bool isSearchEnabled = false;
        public static int editRequestID = 0;

        DatabaseHelper dbhelper = new DatabaseHelper();
        
        public RequestPortal()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void RequestPortal_Load(object sender, EventArgs e)
        {

            
            DataTable dt = dbhelper.Select();

            numberOfRows = dbhelper.getNumberOfRows();




            gridView.DataSource = dt;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string it = ITNO.Text;
            if(!(it.Equals("")) && !(it.Equals("Search..")))
            {
                
                isSearchEnabled = true;
                DataTable dt = dbhelper.search(it);
                gridView.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Enter a valid Employee ID");
                DataTable dt2 = dbhelper.Select();
                numberOfRows = dbhelper.getNumberOfRows();
                gridView.DataSource = dt2;
            }
           

        }

        private void GridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.ColumnIndex == gridView.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                if(isSearchEnabled)
                {
                    string it = ITNO.Text;
                    int id = dbhelper.getRequestIdWhenSearching(it, e.RowIndex);
                    editRequestID = id;
                    EditRequestPopupWindow edit = new EditRequestPopupWindow();
                    edit.ShowDialog();
                }
                else
                {
                    int id = dbhelper.getRequestId(e.RowIndex);
                    editRequestID = id;
                    EditRequestPopupWindow edit = new EditRequestPopupWindow();
                    edit.ShowDialog();
                }
                
            }
            if (e.ColumnIndex == gridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                
                if(!isSearchEnabled)
                {
                    int id = dbhelper.getRequestId(e.RowIndex);
                    if (numberOfRows == dbhelper.getNumberOfRows())
                    {
                        if (dbhelper.deleteRow(id))
                        {
                            MessageBox.Show("Deleted Successfully!");
                            DataTable dt = dbhelper.Select();
                            gridView.DataSource = dt;
                            numberOfRows = dbhelper.getNumberOfRows();


                        }
                        else
                        {
                            MessageBox.Show("Data was not Deleted Successfully!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can't Delete a record right now because the table has been updated frequently!");
                        DataTable dt = dbhelper.Select();
                        gridView.DataSource = dt;
                        numberOfRows = dbhelper.getNumberOfRows();
                    }
                }
                else
                {
                    string it = ITNO.Text;
                    if(!it.Equals(""))
                    {
                        
                        int id = dbhelper.getRequestIdWhenSearching(it, e.RowIndex);
                        if (numberOfRows == dbhelper.getNumberOfRows())
                        {
                            if (dbhelper.deleteRow(id))
                            {
                                MessageBox.Show("Deleted Successfully!");
                                DataTable dt = dbhelper.Select();
                                gridView.DataSource = dt;
                                numberOfRows = dbhelper.getNumberOfRows();


                            }
                            else
                            {
                                MessageBox.Show("Data was not Deleted Successfully!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("You can't Delete a record right now because the table has been updated frequently!");
                            DataTable dt = dbhelper.Select();
                            gridView.DataSource = dt;
                            numberOfRows = dbhelper.getNumberOfRows();
                        }
                    }
                    
                }
               
             
            }



        }

        private void Button2_Click(object sender, EventArgs e)
        {
            isSearchEnabled = false;
            DataTable dt = dbhelper.Select();
            numberOfRows = dbhelper.getNumberOfRows();
            gridView.DataSource = dt;
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                string id = textBox1.Text;
                string date = dateTimePicker1.Text;
                int hours = int.Parse(textBox2.Text);
                string department = textBox4.Text;
                string description = textDescription.Text;

               
                if(dbhelper.insert(id, date, hours, department, description))
                {
                    MessageBox.Show("Request was sent!");
                    textBox1.Text = "";
                    dateTimePicker1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textDescription.Text = "";
                }
                else
                {
                    MessageBox.Show("Request was not sent!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Enter Details Properly!");
            }
           

            


        }   




    }
}
