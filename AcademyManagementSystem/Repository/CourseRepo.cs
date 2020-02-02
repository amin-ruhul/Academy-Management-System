using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

using Entity;
using Interfaces;


namespace Repository
{
    public class CourseRepo : ICourse
    {
        

        #region Select from database

        public DataTable Select()
        {
            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM CourseTable";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dc.ConnectWithDB();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dc.CloseConnection();
            }

            return dt;

        }

        #endregion

        #region AddCourse

        public bool AddCourse(Course c)
        {
            bool isSuccess = false;

            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql =
                    "INSERT INTO CourseTable (CourseId,CourseName ,CourseFee) VALUES (@CourseId,@CourseName ,@CourseFee)";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@CourseId", c.CourseId);
                command.Parameters.AddWithValue("@CourseName", c.CourseName);
                command.Parameters.AddWithValue("@CourseFee", c.CourseFee);
                dc.ConnectWithDB();
                int row = command.ExecuteNonQuery();

                if (row > 0)
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
                MessageBox.Show(e.Message);
            }
            finally
            {
                dc.CloseConnection();
            }



            return isSuccess;
        }

        #endregion

        #region Update

        public bool UpdateCourse(Course c)
        {
            bool isSuccess = false;

            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql =
                    "UPDATE CourseTable SET CourseId=@CourseId,CourseName=@CourseName,CourseFee=@CourseFee WHERE CourseId=@CourseId";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@CourseId", c.CourseId);
                command.Parameters.AddWithValue("@CourseName", c.CourseName);
                command.Parameters.AddWithValue("@CourseFee", c.CourseFee);
                dc.ConnectWithDB();

                int row = command.ExecuteNonQuery();

                if (row > 0)
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
                MessageBox.Show(e.Message);
            }
            finally
            {
                dc.CloseConnection();
            }

            return isSuccess;
        }


        #endregion

        #region Delete

        public bool DeleteCourse(Course c)
        {
            bool isSuccess = false;

            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql = "DELETE FROM CourseTable WHERE CourseId=@CourseId";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@CourseId", c.CourseId);
                dc.ConnectWithDB();

                int row = command.ExecuteNonQuery();
                if (row > 0)
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
                MessageBox.Show(e.Message);
            }
            finally
            {
                dc.CloseConnection();
            }

            return isSuccess;
        }

        #endregion

        #region Search

        public DataTable Search(string keyword)
        {
            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM CourseTable WHERE CourseId LIKE '%" + keyword + "%' OR CourseName LIKE '%" +
                             keyword + "%' OR CourseFee LIKE '%" + keyword + "%'";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dc.ConnectWithDB();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dc.CloseConnection();
            }
            return dt;
        }

        #endregion


        #region selectPrice

        public DataTable GetPrice(string name)
        {
            DataTable dt = new DataTable();
            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql = "SELECT * FROM CourseTable WHERE CourseName=@CourseName";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@CourseName", name);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dc.ConnectWithDB();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dc.CloseConnection();
            }


            return dt;
        }

        #endregion

        #region selectCourse

        public DataTable GetCourse(Course c)
        {
            DataTable dt = new DataTable();
            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql = "SELECT * FROM CourseTable WHERE CourseId=@CourseId";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@CourseId",c.CourseId);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dc.ConnectWithDB();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                dc.CloseConnection();
            }


            return dt;
        }

        #endregion
    }
}
