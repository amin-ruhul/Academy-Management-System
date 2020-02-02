using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Entity;

namespace Interfaces
{
   public interface IStudent
   {
       DataTable Select();
       DataTable SelectOne(Student s);
       bool Insert(Student s);
       bool Update(Student s);
       bool Delete(Student s);
       DataTable Search(string Keyword);
   }
}
