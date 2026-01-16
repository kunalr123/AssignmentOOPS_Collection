using System;
using System.Collections.Generic;
using System.Text;

namespace HRLib
{
   // user defined exception

    internal class EmpException : Exception
    {


        public EmpException(String msg ):base(msg) 
        { 

        }
    }
}
