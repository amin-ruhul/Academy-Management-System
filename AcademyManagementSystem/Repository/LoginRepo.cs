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
   public class LoginRepo: ILogin
    {
        

        public bool LoginFunction(Login l)
        {
            bool isSuccsee = false;

           DatabaseConnectionClass dc = new DatabaseConnectionClass();
            

            try
            {
                dc.ConnectWithDB();
                string sql = "SELECT * FROM LoginTable WHERE UserId=@UserId AND Password=@Password";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);

                command.Parameters.AddWithValue("@UserId", l.UserId);
                command.Parameters.AddWithValue("@Password", l.Password);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    isSuccsee = true;
                }
                else
                {
                    isSuccsee = false;
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

            return isSuccsee;
        }

        public bool InsertUser(Login l)
        {
            bool isSuccess = false;

            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql = "INSERT INTO LoginTable (UserId, Password, Status) VALUES (@UserId, @Password, @Status)";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@UserId", l.UserId);
                command.Parameters.AddWithValue("@Password", l.Password);
                command.Parameters.AddWithValue("@Status", l.Status);

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
        public bool DeleteUser(Login l)
        {
            bool isSuccess = false;

           DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql = "DELETE FROM LoginTable WHERE UserId=@UserId";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@UserId", l.UserId);
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

        public bool UpdateUser(Login l)
        {
            bool isSuccess = false;



            return isSuccess;
        }

        #region ChangePassword

        public bool ChangePassword(Login l)
        {
            bool isSuccess = false;

            DatabaseConnectionClass dc = new DatabaseConnectionClass();
            try
            {
                string sql = "UPDATE LoginTable SET Password=@Password WHERE UserId=@UserId";
                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@UserId", l.UserId);
                command.Parameters.AddWithValue("@Password", l.Password);
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

        #region MyRegion
        public DataTable LoadData(Login l)
        {
            DatabaseConnectionClass dc = new DatabaseConnectionClass();
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM LoginTable WHERE UserId=@UserId";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@UserId", l.UserId);

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


        #region Test

        public Login GetUser(string id, string password)
        {
            DatabaseConnectionClass dcc = new DatabaseConnectionClass();
            Login l = null;
            string query = "SELECT * from LoginTable WHERE Id = '" + id + "' AND Password = '" + password + "'";
            dcc.ConnectWithDB();
            SqlDataReader sdr = dcc.GetData(query);

            while (sdr.Read())
            {
                l = new Login();
                l.UserId = sdr["UserId"].ToString();
                l.Password = sdr["Password"].ToString();
                l.Status = Convert.ToInt32(sdr["Status"]);
            }

            dcc.CloseConnection();

            return l;

        }

        #endregion
    }
}
