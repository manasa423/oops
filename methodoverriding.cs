using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsConsoleApp1
{
    class Parent
    {
         public void Display()
        {
            Console.WriteLine("here is a display method of class parent");
        }

        public virtual void Show()
        {
            Console.WriteLine("here is the show method of class parent");
        }
    }
    class Child : Parent
    {
        public override void Show()
        {
            Console.WriteLine("here is the show method of class child");
        }
    }
    class methodoverriding
    {
        static void Main(string[] args)
        {
            Parent p = new Parent();
            p.Show();
            p = new Child();
            p.Show();
            
        }
    }
}
