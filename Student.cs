using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCoreJava
{
    class Student
    {
        int Studentid;
        String Studentname;
        int contactinfo;
        public void showStudentinfo(int sid,string sname,int phone)
        {
            Studentid = sid;
            Studentname = sname;
            contactinfo = phone;
        }
        public void displayStudentInfo()
        {
            Console.WriteLine(Studentid);
            Console.WriteLine(Studentname);
            Console.WriteLine(contactinfo);
        }
    }
}
