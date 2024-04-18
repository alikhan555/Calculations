using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculations
{
    public class MyExceptions
    {
        public void ThrowArgumentNullException(string arg1)
        {
            if (string.IsNullOrEmpty(arg1))
            {
                throw new Exception("hello");
            }
        }
    }
}
