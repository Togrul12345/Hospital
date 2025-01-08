using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.Bl.Exceptions
{
    public class ModelStateException : Exception
    {
        public ModelStateException(string message) : base(message)
        {
            throw new Exception(message);
        }
        public ModelStateException()
        {
            throw new Exception("Modelstate is not valid");

        }
    }
}
