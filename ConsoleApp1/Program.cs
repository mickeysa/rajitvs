using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        
        static void Main(string[] args)
        {

            #region Old Code
            //Solution Sln = new Solution();       

            //int[] result = Sln.TwoSum(new int[] { 2, 4, 5, 6 }, 9);




            //A a = new A();
            //B b = new B();
            //C c = new C();

            //a.Test(); // output --> "A::Test()"
            //b.Test(); // output --> "B::Test()"
            //c.Test(); // output --> "C::Test()"

            //a = new B();
            //a.Test(); // output --> "A::Test()"

            //b = new C();
            //b.Test(); // output --> "C::Test()"
            //try
            //{

            //}
            //finally
            //{ }

            #endregion

            Console.ReadLine();
        }

         
    }
    public class Const_V_Readonly
    {
        public const int I_CONST_VALUE = 20;
        public readonly int I_RO_VALUE;
        public Const_V_Readonly()
        {
            I_RO_VALUE = 30;
        }
    }

    public class Map
    {
        public int index { get; set; }
        public int value { get; set; }
    }
    public class Solution
    {
        
        public int[] TwoSum(int[] nums, int target)
        {

            List<Map> tt = new List<Map>();
            for (int i = 0; i < nums.Length; i++)
            {

                int compliment = target - nums[i];

                if (tt.Where(p => p.value == compliment).FirstOrDefault() != null)
                {
                    return new int[] { tt.Where(p => p.value == compliment).FirstOrDefault().index, i };
                }
                tt.Add(new Map { index = i, value = nums[i] });
            }

            return new int[] { 0, 0 };

        }
    }
    class A
    {
        public  void Test() { Console.WriteLine("A::Test()"); }
    }

    class B : A
    {
        public new virtual void Test() { Console.WriteLine("B::Test()"); }
    }

    class C : B
    {
        public override void Test() { Console.WriteLine("C::Test()"); }
    }




}
