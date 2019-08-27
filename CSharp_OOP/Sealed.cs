using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp_OOP
{
    sealed class SealedClass
    {
        void myfunv();
    }

    public class test : SealedClass //wrong. will give compilation error    
    {
    }
}
