using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

using Entity;

namespace Interfaces
{
   public interface ICourse
    {
        DataTable Select();
        bool AddCourse(Course c);
        bool UpdateCourse(Course c);
        bool DeleteCourse(Course c);
        DataTable Search(string keyword);
    }
}
