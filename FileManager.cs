using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary; //Binary Files
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp
{
    internal class FileManager
    {

        public bool saveToTextFile(List<Employee> empList)
        {
            string currentrow;

            //open the file
            StreamWriter sw = new StreamWriter("Employee.txt");
            foreach(Employee emp in empList)
            {
                //create one row if record to save into the text file
                currentrow = emp.EmpID.ToString() + "," + emp.EmpName + "," + emp.EmpSalary.ToString();
                sw.WriteLine(currentrow); //save one row into the file

            }
            sw.Close(); //close the file
            return true;
        }

        public List<Employee> openTextFile()
        {
            List<Employee> emplist = new List<Employee>();
            StreamReader sr = new StreamReader("Employee.txt");

            //keep reading file till the end
            while(!sr.EndOfStream)
            {
                string[]values = sr.ReadLine().Split(',');
                //convert array into employee object
                Employee emp = new Employee();
                emp.EmpID = int.Parse(values[0]);
                emp.EmpName = values[1];
                emp.EmpSalary = int.Parse(values[2]);

                emplist.Add(emp); //add emp to list
            }
            sr.Close(); //close stream reader
            return emplist;
        }

        public bool saveToBinary(List<Employee> empList)
        {
            //open to file to append data at the end of the file
            FileStream outFile = new FileStream("empBinary.txt", FileMode.Append, FileAccess.Write);

            //create an object that can be saved as binary(serializing)
            BinaryFormatter myBinFile = new BinaryFormatter();
            foreach (Employee emp in empList)
                myBinFile.Serialize(outFile, emp); //serialize one object each time
            outFile.Close();
            return true;
        }

        public List<Employee> openBinaryFile()
        {
            List<Employee> emplist = new List<Employee>();
            Employee emp = new Employee();

            //create an object that can be desrialized from binary to normal object
            BinaryFormatter binData = new BinaryFormatter();

            //open data file
            FileStream inFile = new FileStream("empBinary.txt", FileMode.Open, FileAccess.Read);

            //read and deseralize all the data into a list
            while(inFile.Position <inFile.Length)
            {
                emp = (Employee) binData.Deserialize(inFile); //read and deserealize data into object
                emplist.Add(emp); //add a reovered object into list

            }
            inFile.Close();
            return emplist; //send a list of objects back to that calls this method
        }


    }
}
