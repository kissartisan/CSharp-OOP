using System;

namespace CSharp_OOP
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    //partial class instance    
        //    partialclassDemo obj = new partialclassDemo();
        //    obj.method1();
        //    obj.method2();
        //}
    }

    static class staticDemo
    {
        //static fields    
        static int x = 10, y;

        //static method    
        static void calcute()
        {
            y = x * x;
            Console.WriteLine(y);
        }
        //static void Main(string[] args)
        //{
        //    //function calling directly    
        //    staticDemo.calcute();
        //}
    }
}
