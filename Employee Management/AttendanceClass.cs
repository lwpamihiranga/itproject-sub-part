using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Management
{
    class AttendanceClass
    {
        
        public int AttendId;

        public int EmployeeId;

        public string Date;

        public int ArrivedTime;

        public int LeftTime;

      

        static string myConnectionString = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;


        public bool Insert(AttendanceClass a)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "INSERT INTO Attendance(EmpID,date,inTime) VALUES (@EmpID,@date,@inTime)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@EmpID", a.EmployeeId);
                cmd.Parameters.AddWithValue("@date", a.Date);
                cmd.Parameters.AddWithValue("@inTime", a.ArrivedTime);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;       
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {

            }
            return isSuccess;
        }


        public DataTable Select()
        {
            SqlConnection conn = new SqlConnection(myConnectionString);

            DataTable dt = new DataTable();

            try
            {/*
                string sql = "SELECT EmpID,date,inTime,outTime  FROM Attendance";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);*/
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
                
            }
            return dt;
        }

        public bool Update(AttendanceClass a)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "UPDATE Attendance SET EmpID=@EmpID,date=@date,inTime=@inTime,outTime=@outTime WHERE AttendID=@AttendID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@EmpID", a.EmployeeId);
                cmd.Parameters.AddWithValue("@date", a.Date);
                cmd.Parameters.AddWithValue("@inTime", a.ArrivedTime);
                cmd.Parameters.AddWithValue("@outTime", a.LeftTime);
                cmd.Parameters.AddWithValue("@AttendID", a.AttendId);



                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;
                    
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    public bool Delete(AttendanceClass a)
        {
            bool isSuccess = false;

            SqlConnection conn = new SqlConnection(myConnectionString);

            try
            {
                string sql = "DELETE FROM Attendance WHERE AttendID=@AttendID";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@AttendId", a.AttendId);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                if (rows > 0)
                {
                    isSuccess = true;

                }
                else
                {
                    isSuccess = false;
                }
            
            }
            catch(Exception e)
            {

            }
            finally
            {
                conn.Close();
            }
            return isSuccess;
        }

    }
    
}







