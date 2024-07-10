using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApp
{
    public partial class frmEployeeApp : Form
    {
        //list data structure to hold object dta in RAM
        List<Employee> empList = new List<Employee>();

        //list data structure to hold data for display
        List<Employee> dispList = new List<Employee>();

        public frmEployeeApp()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmEployeeApp_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();

            //get data for the new object
            emp.EmpID = Convert.ToInt32(tbxEmployeeID.Text);
            emp.EmpName = tbxEmployeeName.Text;
            emp.EmpSalary = Convert.ToInt32(tbxEmployeeSalary.Text);

            //add the ojbect to the data list
            empList.Add(emp);

            //send to a list for displaying
            dispList = empList;

            //call a method to display the list
            DisplayListObjs(dispList);

        }
        private void DisplayListObjs(List<Employee> objList)
        {
            //clear the list box for displaying the new information
            lstEmployeeList.Items.Clear();

            //$is used for string formatting
            //{,} displays contents and width

            string title = $"{"EmpId",-10} {"Name",-15}" + $"{"Salary",-15} {"Wages",-15}";

            //title is displayed in a ListBox
            lstEmployeeList.Items.Add(title);

            //a list of objects are displayed
            lstEmployeeList.Items.AddRange(objList.ToArray());

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            double total = 0.0;
            foreach (Employee emp in dispList)
            {
                //process the total
                total = total + emp.EmpSalary;
            }
            //output the result
            lblTotal.Text = total.ToString("C");
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Employee emp in dispList)
            {
                //process the total
                count = count + 1;
            }
            //output the result
            lblCount.Text= count.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lblTotal.Text = ""; //clear text data in label
            lblCount.Text = ""; //clear text data in label
            empList.Clear(); //delete all employee data in RAM
            dispList.Clear(); //delete all displaying data in RAM
            lstEmployeeList.Items.Clear(); //delete all the display from the screen

        }

        private void btnSaveToTextFile_Click(object sender, EventArgs e)
        {
            bool savedSuccess = false;
            FileManager fm = new FileManager();

            //send a list of objects to be saved by the method in File Manager class
            savedSuccess = fm.saveToTextFile(empList);
            if (savedSuccess)
            {
                MessageBox.Show("Data being successfully saved !");
                lstEmployeeList.Items.Clear(); //clear screen
                empList.Clear();
            }
            else
            {
                {
                    MessageBox.Show("Error in saving the data");
                }
            }
        }
        private void btnLoadFromTextFile_Click(object sender, EventArgs e)
        {
            FileManager fm1 = new FileManager();
            empList = fm1.openTextFile();
            dispList.Clear();
            dispList = empList; //send a copy of loaded data for displaying
            DisplayListObjs(dispList);  //call method for output

        }

        private void btnSaveToBinary_Click(object sender, EventArgs e)
        {
            bool saveSuccess = false;
            FileManager fm2 = new FileManager();
            saveSuccess = fm2.saveToBinary(empList);

            if (saveSuccess==true)
            {
                MessageBox.Show("Data being successfullt saved in a binaryfile ");
                lstEmployeeList.Items.Clear();
                empList.Clear();
            }
            else
            {
                MessageBox.Show("Error in saving data");
            }
        }

        private void btnLoadFromBinaryFile_Click(object sender, EventArgs e)
        {
            FileManager fm3 = new FileManager();
            empList = fm3.openBinaryFile();
            dispList.Clear();
            dispList = empList; //send a copy of loaded data for displaying
            DisplayListObjs(dispList);  //call method for output
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Employee> results = new List<Employee>();
            Filter fl = new Filter(); //create an object to use the search method
            //pass a list of objects and search item from text box to search method
            results = fl.searchName(empList, tbxEmployeeName.Text);

            dispList.Clear();
            dispList = results;
            DisplayListObjs(dispList);  //display the searched results
        }
    }
}
