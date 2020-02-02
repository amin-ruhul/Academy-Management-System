using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Entity;

namespace Interfaces
{
   public interface IEmployee
    {

        DataTable Select();
        DataTable MyInfo(Employee E);
        DataTable Search(string keyword);
        bool Insert(Employee E);
        bool Update(Employee E);
        bool Delete(Employee E);
    }
}
