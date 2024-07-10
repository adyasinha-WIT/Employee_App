using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class Filter
    {

        public List<Employee>searchName(List<Employee> empList, string searchName)
        {
            //create a temp list to hold searching results
            List<Employee> searchResults = new List<Employee>();

            foreach (Employee emp in empList)
            {
                if (emp.EmpName.Contains(searchName))
                {
                    //add the matched object into the result list
                    searchResults.Add(emp);
                }
            }
            return searchResults;
        }

    }
}
