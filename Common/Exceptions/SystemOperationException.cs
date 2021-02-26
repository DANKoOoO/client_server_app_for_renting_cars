using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class SystemOperationException : Exception
    {
        public SystemOperationException() : base("Server error!")
        {

        }
        public SystemOperationException(string msg) : base(msg)
        {

        }
    }
}
