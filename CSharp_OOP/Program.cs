using System;

namespace CSharp_OOP
{
    class customer
    {
        // Member Variables    
        public string Name;

        //constructor for initializing fields    
        public customer(string fname, string lname)
        {
            Name = fname + " " + lname;
        }
   
        //method for displaying customer records    
        public void AppendData()
        {
            Console.WriteLine(Name);
        }

        //Entry point    
        static void Main(string[] args)
        {
            // object instantiation    
            customer obj = new customer("Barack", "Obama");

            //Method calling    
            obj.AppendData();
        }
    }
}
