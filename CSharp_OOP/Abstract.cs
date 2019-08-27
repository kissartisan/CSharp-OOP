using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    //abstract class    
    public abstract class Employees
    {
        //abstract method with no implementation    
        public abstract void displayData();
    }

    //derived class    
    public class test : Employees
    {
        //abstract class method implementation    
        public override void displayData()
        {
            Console.WriteLine("Abstract class method");
        }
    }

    class abstractClass
    {
        static void Main(string[] args)
        {
            // class instance    
            new test().displayData();
        }
    }
}
