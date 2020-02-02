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
   public class EmployeeRepo : IEmployee
    {


        #region Select Data from DataBase

        public DataTable Select()
        {
            
            DatabaseConnectionClass dc = new DatabaseConnectionClass();
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM EmployeeTable";

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

        #region show my info

        public DataTable MyInfo(Employee E)
        {
            DatabaseConnectionClass dc = new DatabaseConnectionClass();
            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM EmployeeTable WHERE EmpId=@EmpId";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                command.Parameters.AddWithValue("@EmpId", E.EmpId);

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


        #region Inset Employee intro Database

        public bool Insert(Employee E)
        {

            bool isSuccess = false;

            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql =
                    "INSERT INTO EmployeeTable(EmpId, EmpName, EmpSalary, EmpEmail, Gender, Designation) VALUES (@EmpId, @EmpName, @EmpSalary, @EmpEmail, @Gender, @Designation)";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);

                command.Parameters.AddWithValue("@EmpId", E.EmpId);
                command.Parameters.AddWithValue("@EmpName", E.EmpName);
                command.Parameters.AddWithValue("@EmpSalary", E.EmpSalary);
                command.Parameters.AddWithValue("@EmpEmail", E.EmpEmail);
                command.Parameters.AddWithValue("@Gender", E.Gender);
                command.Parameters.AddWithValue("@Designation", E.Designation);

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

        #region update database

        public bool Update(Employee E)
        {
            bool isSuccess = false;

            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {

                string sql =
                    "UPDATE EmployeeTable SET  EmpName=@EmpName, EmpSalary=@EmpSalary, EmpEmail=@EmpEmail, Gender=@Gender, Designation=@Designation WHERE EmpId=@EmpId";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);

                command.Parameters.AddWithValue("@EmpId", E.EmpId);
                command.Parameters.AddWithValue("@EmpName", E.EmpName);
                command.Parameters.AddWithValue("@EmpSalary", E.EmpSalary);
                command.Parameters.AddWithValue("@EmpEmail", E.EmpEmail);
                command.Parameters.AddWithValue("@Gender", E.Gender);
                command.Parameters.AddWithValue("@Designation", E.Designation);
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

        #region Delet from Database

        public bool Delete(Employee E)
        {
            bool isSuccess = false;

            DatabaseConnectionClass dc = new DatabaseConnectionClass();

            try
            {
                string sql = "DELETE FROM EmployeeTable WHERE EmpId=@EmpId";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);

                command.Parameters.AddWithValue("EmpId", E.EmpId);
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
                string sql = "SELECT * FROM EmployeeTable WHERE EmpId LIKE '%" + keyword + "%' OR EmpName LIKE '%" +
                             keyword + "%' OR EmpSalary LIKE '%" + keyword + "%' OR Gender LIKE '%" + keyword + "%'";

                SqlCommand command = new SqlCommand(sql, dc.MyConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                dc.ConnectWithDB();
                adapter.Fill(dt);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }

        #endregion

    }
}
