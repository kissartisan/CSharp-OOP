using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    class FunOverload
    {
        public string name;

        //overloaded functions    
        public void setName(string last)
        {
            name = last;
        }

        public void setName(string first, string last)
        {
            name = first + "" + last;
        }

        public void setName(string first, string middle, string last)
        {
            name = first + "" + middle + " " + last;
        }

        public void getName()
        {
            Console.WriteLine(name);
        }

        //Entry point    
        static void Main(string[] args)
        {
            FunOverload obj = new FunOverload();

            obj.setName("barack");
            obj.setName("barack ", " obama ");
            obj.setName("barack ", "hussian", "obama");

            obj.getName();

        }
    }
}
