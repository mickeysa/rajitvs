using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        readonly int s = 90;

        public Program()
        {
            Console.WriteLine(s);
            s = 89;
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            const int ss = 23;
            
            Base b = new Derived();                     
            Derived d = new Derived();

            b.DoIt();                       
            d.DoIt();

            for (int row = 8; row >= 1; --row)
            {
                for (int col = 1; col <= row; ++col)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
    public class Base
    {
         
        public  void DoIt()
        {
            Console.WriteLine("Base Virtual");
        }
    }

    public   class Derived : Base
    {
        public new void DoIt()
        {
            Console.WriteLine("Derived Virtual");
        }
    }
}
