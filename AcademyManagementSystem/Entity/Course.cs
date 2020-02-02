using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class Course
   {
       private string courseId;
       private string courseName;
       private double courseFee;

       public string CourseId
       {
           get { return courseId;}
           set { this.courseId = value; }
       }

       public string CourseName
       {
           get { return courseName;}
           set { this.courseName = value; }
       }

       public double CourseFee
       {
           get { return courseFee;}
           set { this.courseFee = value; }
       }
    }
}
