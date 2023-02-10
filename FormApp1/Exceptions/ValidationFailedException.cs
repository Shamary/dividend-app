using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormApp1.Exceptions
{
    internal class ValidationFailedException : Exception
    {
        public ValidationFailedException()
        {

        }

        public ValidationFailedException(string message): base(message)
        {

        }
    }
}
