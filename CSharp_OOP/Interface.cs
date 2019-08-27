using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    // interface    
    public interface xyz
    {
        void methodA();
        void methodB();
    }

    // interface method implementation    
    class interfaceTest : xyz
    {
        public void methodA()
        {
            Console.WriteLine("methodA");
        }
        public void methodB()
        {
            Console.WriteLine("methodB");
        }
    }

    // interface method implementation    
    class interfaceTest2 : xyz
    {
        public void methodA()
        {
            Console.WriteLine("methodC");
        }
        public void methodB()
        {
            Console.WriteLine("methodD");
        }
    }

    class interfaceDemo
    {
        static void Main(string[] args)
        {
            interfaceTest obj = new interfaceTest();
            obj.methodA();
            obj.methodB();

            interfaceTest2 obj2 = new interfaceTest2();
            obj2.methodA();
            obj2.methodB();
        }
    }
}
