using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entity;

namespace Interfaces
{
   public interface ILogin
    {
        bool LoginFunction(Login l);
        bool InsertUser(Login l);
        bool DeleteUser(Login l);
        bool UpdateUser(Login l);
        bool ChangePassword(Login l);
        DataTable LoadData(Login l);
    }
}
