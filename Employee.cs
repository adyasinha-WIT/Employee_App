using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    [Serializable]
    internal class Employee
    {

        //fields declared
        int empID;
        string empName;
        double empSalary;

        //properties generated
        public int EmpID { get => empID; set => empID = value; }
        public string EmpName { get => empName; set => empName = value; }
        public double EmpSalary { get => empSalary; set => empSalary = value; }

        //method to calculate wages
        public double Wages()
        {
            double wages = EmpSalary * 7 / 365;
            return wages;
        }

        //method to display the object information
        public override string ToString()
        {
            string objMsg = $"{EmpID.ToString(), -10} {EmpName, -15}" + $"{EmpSalary.ToString("C"), -15} {Wages().ToString("C"), -15}";
            return objMsg;
        }



    }
}
