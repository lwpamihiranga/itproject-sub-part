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
using System.Threading;

namespace Employee_Management
{
    
    public partial class RequestPortal : UserControl
    {



        static int numberOfRows = 0;
        public static bool isSearchEnabled = false;
        public static int editRequestID = 0;
        static DataTable downloadingDataTable = null;
        //bool isThreadNeedToRun = false;

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
            dateTimePicker1.MinDate = DateTime.Today;
            DataTable dt = dbhelper.Select();
            numberOfRows = dbhelper.getNumberOfRows();
            gridView.DataSource = dt;

            List<String> list = new List<string>();
            List<String> list2 = new List<string>();

            DatabaseHelper helper = new DatabaseHelper();
            DataTable dtss = helper.getEmployeeIDs();
            foreach (DataRow row in dtss.Rows)
            {
                list.Add(row["EmpId"].ToString());
            }
            foreach (DataRow row in dtss.Rows)
            {
                list2.Add(row["Department"].ToString());
            }
            string[] ids = list.ToArray();
            string[] depts = list2.ToArray();


            AutoCompleteStringCollection allowedTypes = new AutoCompleteStringCollection();
            allowedTypes.AddRange(ids);
            textBox1.AutoCompleteCustomSource = allowedTypes;
            textBox1.AutoCompleteCustomSource = allowedTypes;
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;



            AutoCompleteStringCollection allowedTypes2 = new AutoCompleteStringCollection();
            allowedTypes2.AddRange(depts);
            textBox4.AutoCompleteCustomSource = allowedTypes2;
            textBox4.AutoCompleteCustomSource = allowedTypes2;
            textBox4.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox4.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        public void refreshDataGridView()
        {
            DataTable dt = dbhelper.Select();
            numberOfRows = dbhelper.getNumberOfRows();
            gridView.DataSource = dt;
           

        }
        public void setVisibility()
        {
            String s = comboBox1.Text;
            if (s.Equals("Sort by Date"))
            {
                textBox3.Visible = false;
                textBox5.Text = "Enter Date";
                
              
            }
            if (s.Equals("Sort by EmployeeID"))
            {
                textBox3.Visible = false;
                textBox5.Text = "Enter ID";
            }
            if (s.Equals("Sort between a Range"))
            {
                textBox3.Visible = true;
                textBox5.Text = "End Date";
                textBox3.Text = "Starting Date";
            }
            if(s.Equals("Sort by Dept and Date"))
            {
                textBox3.Visible = true;
                textBox5.Text = "Enter Dept";
                textBox3.Text = "Enter Date";
            }
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
                    refreshDataGridView();
                }
                
            }
            if (e.ColumnIndex == gridView.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                DialogResult result = MessageBox.Show("Do You Want to delete?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (result.Equals(DialogResult.OK))
                {
                    if (!isSearchEnabled)
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
                                refreshDataGridView();


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
                        if (!it.Equals(""))
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

                if(description == null || description.Equals(""))
                {
                    MessageBox.Show("Enter a Description");
                    return;
                }
                if (department == null || department.Equals(""))
                {
                    MessageBox.Show("Enter a Department");
                    return;
                }


                if (dbhelper.insert(id, date, hours, department, description))
                {
                    MessageBox.Show("Request was sent!");
                    textBox1.Text = "";
                    dateTimePicker1.Text = "";
                    textBox2.Text = "";
                    textBox4.Text = "";
                    textDescription.Text = "";

                    refreshDataGridView();
         
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
       

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void CrystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            String comboText = comboBox1.Text;
            String text2 = textBox5.Text;
            String text1 = textBox3.Text;

            DatabaseHelper helper = new DatabaseHelper();


            dataGridView2.DataSource = null;
            downloadingDataTable = null;

            if (comboText.Equals(""))
            {
                MessageBox.Show("Select a filter first");
                return;
            }

            if (comboText.Equals("Sort by Date"))
            {
                if(text2.Equals("") || text2.Equals("Enter Date"))
                {
                    MessageBox.Show("Enter a Date");
                }
                else
                {
                    DataTable dt = helper.getRequestDetailsByDate(text2);
                    dataGridView2.DataSource = dt;
                    downloadingDataTable = dt;

                }
            }
            else if(comboText.Equals("Sort by EmployeeID"))
            {
                if (text2.Equals("") || text2.Equals("Enter ID"))
                {
                    MessageBox.Show("Enter a ID");
                }
                else
                {
                  
                    DataTable dt = helper.getRequestDetailsByEmpID(text2);
                    dataGridView2.DataSource = dt;
                    downloadingDataTable = dt;
                }
            }
            else if(comboText.Equals("Sort between a Range"))
            {
                if(text1.Equals("") || text1.Equals("Starting Date"))
                {
                    MessageBox.Show("Enter Starting Date");
                }
                else if (text2.Equals("") || text2.Equals("End Date"))
                {
                    MessageBox.Show("Enter End Date");
                }
                else
                {
                    DataTable dt = helper.getRequestDetailsByARange(text1, text2);
                    dataGridView2.DataSource = dt;
                    downloadingDataTable = dt;

                }
            }
            else if(comboText.Equals("Sort by Dept and Date"))
            {
                if (text1.Equals("") || text1.Equals("Enter Date"))
                {
                    MessageBox.Show("Enter the Date");
                }
                else if (text2.Equals("") || text2.Equals("Enter Dept"))
                {
                    MessageBox.Show("Enter the Department");
                }
                else
                {
                    DataTable dt = helper.getRequestDetailsByDateAndDept(text1, text2);
                    dataGridView2.DataSource = dt;
                    downloadingDataTable = dt;
                }
            }






          
            
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if(downloadingDataTable == null)
            {
                MessageBox.Show("Coudn't create report because the Dataset is Empty");
                return;
            }
            DatabaseHelper helper = new DatabaseHelper();
            if (helper.createPDF(downloadingDataTable, "G:\\SQL LITE DATABSE\\report.pdf"))
            {
                MessageBox.Show("Report was saved as G:\\SQL LITE DATABSE\\report.pdf");
            }
            else
            {
                MessageBox.Show("Something went wrong!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ///MessageBox.Show("Changed");
            setVisibility();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
