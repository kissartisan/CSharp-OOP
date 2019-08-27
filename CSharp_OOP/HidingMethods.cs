using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    class myBase
    {
        //virtual function    
        public virtual void VirtualMethod()
        {
            Console.WriteLine("Virtual method defined in the Base class");
        }

        public void test()
        {
            Console.WriteLine("Hello world!");
        }
    }

    class myDerived : myBase
    {
        // hiding the implementation of base class method    
        public new void VirtualMethod()
        {
            Console.WriteLine("Virtual method defined in the Derive class");

            //still access the base class method    
            base.VirtualMethod();
            base.test();
        }
    }

    class virtualClass
    {
        //static void Main(string[] args)
        //{
        //    // class instance    
        //    new myDerived().VirtualMethod();
        //    Console.Read();
        //}
    }
}
