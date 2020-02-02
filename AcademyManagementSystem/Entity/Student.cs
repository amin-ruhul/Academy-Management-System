using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entity
{
   public class Student
   {
       private string id;
       private string name;
       private string email;
       private string course;
       private double totalFee;
       private int flag;

       public string Id
       {
           get { return id;}
           set { id = value; }
       }

       public string Name
       {
           get { return name;}
           set { name = value; }
       }

       public string Email
       {
           get { return email;}
           set { email = value; }
       }

       public string Course
       {
           get { return course;}
           set { course = value; }
       }

       // public string Fees { get; set; }
       public Double TotalFee
       {
           get { return totalFee;}
           set { totalFee = value; }
       }

       public int Flag
       {
           get { return flag;}
           set { flag = value; }
       }
    }
}
