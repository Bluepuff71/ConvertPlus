using System;
using System.Collections.Generic;
using System.Text;

namespace ConvertPlus.Exceptions
{
    public class UnderflowException : Exception
    {
        public UnderflowException(string message) : base (message)
        {
        }
    }
}
