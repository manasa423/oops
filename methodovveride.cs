using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp1
{
    class tesla
    {
        int num1;
        int num2;
       public void ReadValues()
        {
            Console.Write("enter num1:");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("enter num2:");
            num2 = int.Parse(Console.ReadLine());
        }
        public void ShowValues()
        {
            Console.WriteLine($"num1={num1}\tnum2={num2}");
           }
     
        public override string ToString()
        {
            return $"num1 ={ num1}\tnum2 ={num2}";
        }



    }

    class methodovveride
    {
        static void Main(string[] args)

        {
            tesla t = new tesla();
            t.ReadValues();

            Console.WriteLine(t);

        }




    }
}

