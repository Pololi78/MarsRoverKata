using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKataApi.Exceptions
{
    
    public class RoverStartingPositionInvalidException : Exception
    {
        public RoverStartingPositionInvalidException()
        {
        }

        public RoverStartingPositionInvalidException(String message)
            : base(message)
        {
        }

        public RoverStartingPositionInvalidException(String message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
