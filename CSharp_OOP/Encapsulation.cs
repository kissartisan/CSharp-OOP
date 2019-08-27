using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    class Encapsulation
    {
        /// <summary>    
        /// Every member Variable and Function of the class are bind    
        /// with the Encapsulation class object only and safe with     
        /// the outside inference    
        /// </summary>    

        // Encapsulation Begin    
        int x;

        //class constructor    
        public Encapsulation(int xI)
        {
            this.x = xI;
        }

        //calculating the square    
        public void MySquare()
        {
            int Calc = x * x;
            Console.WriteLine(Calc);
        }

        // End of Encapsulation    

        //Entry point    
        static void Main(string[] args)
        {
            //instance created    
            Encapsulation obj = new Encapsulation(20);

            obj.MySquare();

        }

    }
}
