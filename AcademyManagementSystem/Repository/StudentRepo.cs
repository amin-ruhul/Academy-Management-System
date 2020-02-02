using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entity;
using Interfaces;

namespace Repository
{
   public class StudentRepo : IStudent
    {
        DatabaseConnectionClass dc;

        public StudentRepo()
        {
            dc = new DatabaseConnectionClass();
        }

        #region LoadData

        public DataTable Select()
        {
            DataTable dt = new DataTable();
            

            try
            {
                dc.ConnectWithDB();
                string sql = "SELECT * FROM StudentTable";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
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

        #region SelectStudent

        public DataTable SelectOne(Student s)
        {
            DataTable dt = new DataTable();

            
            try
            {
                dc.ConnectWithDB();
                string sql = "SELECT * FROM StudentTable WHERE Id=@Id";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@Id", s.Id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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

        #region Insert Student

        public bool Insert(Student s)
        {
            bool isSuccess = false;


            try
            {
                dc.ConnectWithDB();
                string sql =
                    "INSERT INTO StudentTable (Id,Name,Email,Course,TotalFee,Flag) VALUES (@Id,@Name,@Email,@Course,@TotalFee,@Flag)";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@Id", s.Id);
                command.Parameters.AddWithValue("@Name", s.Name);
                command.Parameters.AddWithValue("@Email", s.Email);
               // command.Parameters.AddWithValue("@Fees", s.Fees);
                command.Parameters.AddWithValue("@Course", s.Course);
                command.Parameters.AddWithValue("@TotalFee", s.TotalFee);
                command.Parameters.AddWithValue("@Flag", s.Flag);

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


        #region UpdateStudent

        public bool Update(Student s)
        {
            bool isSuccess = false;

            try
            {
                dc.ConnectWithDB();

                string sql =
                    "UPDATE StudentTable SET Name=@Name,Email=@Email,Course=@Course,TotalFee=@TotalFee,Flag=@Flag WHERE Id=@Id";
                SqlCommand command = new SqlCommand(sql,dc.MyConnection);
                command.Parameters.AddWithValue("@Id", s.Id);
                command.Parameters.AddWithValue("@Name", s.Name);
                command.Parameters.AddWithValue("@Email", s.Email);
                command.Parameters.AddWithValue("@Course", s.Course);
               // command.Parameters.AddWithValue("@Fees", s.Fees);
                command.Parameters.AddWithValue("@TotalFee", s.TotalFee);
                command.Parameters.AddWithValue("@Flag", s.Flag);

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

        #region DeleteStudent

        public bool Delete(Student s)
        {
            bool isSuccess = false;

            try
            {
                dc.ConnectWithDB();
                string sql = "DELETE FROM StudentTable WHERE Id=@Id";
                SqlCommand command = new SqlCommand(sql,dc.MyConnection);
                command.Parameters.AddWithValue("@Id", s.Id);

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

        #region Search Student

        public DataTable Search(string Keyword)
        {
            DataTable dt = new DataTable();

            try
            {
                dc.ConnectWithDB();
                string sql = "SELECT * FROM StudentTable WHERE Id LIKE '%" + Keyword + "%' OR Name LIKE '%" + Keyword +
                             "%' OR TotalFee LIKE '%" + Keyword + "%'";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
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
