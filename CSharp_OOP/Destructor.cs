using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    class Destructor
    {
        // Member Variables    
        public int x, y;

        //constuctor for initializing fields    
        Destructor()
        {
            Console.WriteLine("Fields inititalized");
            x = 10;
        }

        //method for get field    
        public void getData()
        {
            y = x * x;
            Console.WriteLine(y);
        }

        //method to release resource explicitly    
        public void Dispose()
        {
            Console.WriteLine("Fields cleaned");
            x = 0;
            y = 0;
        }

        //destructor    
        ~Destructor()
        {
            Dispose();
        }

        //Entry point    
        //static void Main(string[] args)
        //{
        //    //instance created    
        //    Destructor obj = new Destructor();

        //    obj.getData();

        //}
    }
}
