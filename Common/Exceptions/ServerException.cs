using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Exceptions
{
    public class ServerException : Exception
    {
        public ServerException() : base("Server error!")
        {
            
        }
        public ServerException(string msg) : base(msg)
        {

        }
    }
}
