using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    //Base Class    
    public class Father
    {

        //constructor    
        public Father(string additionalWord = "test")
        {
            Console.WriteLine("Father class constructor " + additionalWord);
        }

        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }

    //Derived class    
    public class Child : Father
    {
        public Child()
            : base("etc...")
        {
            Console.WriteLine("Child class constructor");
        }
        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }
    class Inheritance
    {
        //Entry point    
        static void Main(string[] args)
        {
            //Here Child object can access both class methods    
            Child cObj = new Child();
            cObj.FatherMethod();
            cObj.ChildMethod();
            Console.Read();
        }
    }
}
