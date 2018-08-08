using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKataApi.Exceptions
{

    public class RoverStartingDirectionInvalidException : Exception
    {
        public RoverStartingDirectionInvalidException()
        {
        }

        public RoverStartingDirectionInvalidException(String message)
            : base(message)
        {
        }

        public RoverStartingDirectionInvalidException(String message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
