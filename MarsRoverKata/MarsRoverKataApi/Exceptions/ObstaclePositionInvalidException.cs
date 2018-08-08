using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKataApi.Exceptions
{
    
    public class ObstaclePositionInvalidException : Exception
    {
        public ObstaclePositionInvalidException()
        {
        }

        public ObstaclePositionInvalidException(String message)
            : base(message)
        {
        }

        public ObstaclePositionInvalidException(String message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
