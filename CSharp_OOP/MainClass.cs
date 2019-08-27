using System;

namespace CSharp_OOP
{
    class MainClass
    {
        static void Main(string[] args)
        {
            //partial class instance    
            PartialClass obj = new PartialClass();
            obj.method1();
            obj.method2();
        }
    }

}
