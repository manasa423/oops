using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsApp2
{
    class Program
    {
        int docId;
        string docName;
        int docFees;
        public void SetDocInfo(int id, string name, int fees)
        {
            docId = id;
            docName = name;
            docFees = fees;

        }
        public void ShowDocInfo()
        {
            Console.WriteLine(docId);
            Console.WriteLine(docName);
            Console.WriteLine(docFees);

        }
    }
    
    
    class Doctor
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SetDocInfo(3, "rahul", 500);
            p.ShowDocInfo();

        }
    }
}
