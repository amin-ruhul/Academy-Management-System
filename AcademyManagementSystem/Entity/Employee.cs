using System;
using System.Collections.Generic;
using System.Text;

namespace Entity
{
   public class Employee
    {
        private string empId;
        private string empName;
        private double empSalary;
        private string empEmail;
        private string gender;
        private string designation;

        public string EmpId
        {
            get { return empId; }
            set { this.empId = value; }
        }

        public string EmpName
        {
            get { return empName; }
            set { this.empName = value; }
        }

        public double EmpSalary
        {
            get { return empSalary; }
            set { this.empSalary = value; }
        }

        public string EmpEmail
        {
            get { return empEmail; }
            set { this.empEmail = value; }
        }

        public string Gender
        {
            get { return gender; }
            set { this.gender = value; }
        }

        public string Designation
        {
            get { return designation; }
            set { this.designation = value; }
        }

    }
}
