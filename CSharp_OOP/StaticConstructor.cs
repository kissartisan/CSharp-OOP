using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    class StaticConstructor
    {
        // Member Variables    
        static private int x;

        //constuctor for static initializing fields    
        static StaticConstructor()
        {
            x = 10;
        }

        //method for get  static field    
        static public void getData()
        {
            Console.WriteLine(x);
        }

        //Entry point    
        static void Main(string[] args)
        {
            //static Method calling    
            StaticConstructor.getData();
        }
    }
}
