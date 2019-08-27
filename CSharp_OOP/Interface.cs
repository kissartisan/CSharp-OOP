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

    public interface abc : xyz
    {
        void methodC();
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

        public void methodC()
        {
            Console.WriteLine("methodC");
        }
    }


    // interface method implementation    
    class interfaceTest2 : abc
    {
        public void methodA()
        {
            Console.WriteLine("methodC");
        }

        public void methodB()
        {
            Console.WriteLine("methodD");
        }

        public void methodC()
        {
            Console.WriteLine("methodE");
        }
    }

    class interfaceDemo
    {
        //static void Main(string[] args)
        //{
        //    interfaceTest obj = new interfaceTest();
        //    obj.methodA();
        //    obj.methodB();
        //    obj.methodC();

        //    interfaceTest2 obj2 = new interfaceTest2();
        //    obj2.methodA();
        //    obj2.methodB();
        //    obj2.methodC();
        //}
    }
}
