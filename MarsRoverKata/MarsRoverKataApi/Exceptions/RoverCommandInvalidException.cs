using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKataApi.Exceptions
{

    public class RoverCommandInvalidException : Exception
    {
        public RoverCommandInvalidException()
        {
        }

        public RoverCommandInvalidException(String message)
            : base(message)
        {
        }

        public RoverCommandInvalidException(String message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
