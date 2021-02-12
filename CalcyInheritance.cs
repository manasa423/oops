using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsApp2
{
    class BasicCal
    {
        public void Sum(int x,int y)
          {
        Console.WriteLine(x+y);

        }
    public void Sub(int x,int y)
          {
        Console.WriteLine(x-y);

        }
        public void Mul(int x, int y)
        {
            Console.WriteLine(x * y);

        }

    }
    class SciCal:BasicCal
    {
        public void Sine(int x, int y)
        {
            Console.WriteLine(x - y);

        }
        public void Cos(int x, int y)
        {
            Console.WriteLine(x - y);

        }

    }

   
    
     class CalcyInheritance
    {
        static void Main(string[] args)
        {
            SciCal s = new SciCal();
            s.Sub(4, 5);
            s.Sine(90);

        }
    }
}
