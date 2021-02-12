using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsApp2
{
    class Employee
    {
        int empId;
        string empName;  //Instance members
        int empSal;
        public void SetEmpInfo(int id, string ename, int esal) //Assigning the data
        {
            empId = id;
            empName = ename;
            empSal = esal;
        }
        public void ShowEmpInfo()
        {
            Console.WriteLine(empId);
            Console.WriteLine(empName);
            Console.WriteLine(empSal);
        }
    }
    class program
    {
        static void Main(string[] args)
        {

            Employee e= new Employee();
            e.SetEmpInfo(111, "abc", 5000);
            e.ShowEmpInfo();

        }
    }
}
