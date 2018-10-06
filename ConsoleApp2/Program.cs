using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
namespace ConsoleApp2
{
    public class Parent   //:SuperParent
    {
        //static Parent()
        //{
        //    Console.WriteLine(" I am a Static Parent Constructor");
        //}

        public Parent()
        {
            Console.WriteLine(" I am a Parent Constructor");
        }

        public virtual void Print()
        {
           
            Console.WriteLine(" I am a Parent print ");
        }
    }

    public class Child : Parent
    {
        static Child()
        {
            Console.WriteLine(" I am a Static Child Constructor");
        }

        public Child()
        {
            Console.WriteLine(" I am a Child Constructor");
        }

          public   new void Print()
        {
            Console.WriteLine(" I am a Child  print");
        }
    }

     
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ---- Parent -----");

            Parent P = new Child();
            P.Print();

            //// Now point to note is Parent constructor call first and child 
            //Console.WriteLine(" ---- Child -----");
            //Child C = new Child();
            //C.Print();

            //// Parent method will be called not child method
            //Console.WriteLine(" ---- Parent via child -----");
            //Parent PC = new Child();
            //PC.Print();

            Console.ReadKey();

            //Const_V_Readonly const_V_Readonly = new Const_V_Readonly();
            //Console.WriteLine("constvalue= " +Const_V_Readonly.I_CONST_VALUE.ToString()+" ReadOnly ="+const_V_Readonly.I_RO_VALUE);
            //Console.ReadLine();
            
        }
    }
}
