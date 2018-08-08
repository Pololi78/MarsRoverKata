using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRoverKataApi.Exceptions
{
    
    public class GridDimensionInvalidException : Exception
    {
        public GridDimensionInvalidException()
        {
        }

        public GridDimensionInvalidException(String message)
            : base(message)
        {
        }

        public GridDimensionInvalidException(String message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
