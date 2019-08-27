using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    static class StaticClass
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
        //    StaticClass.calcute();
        //}
    }
}
