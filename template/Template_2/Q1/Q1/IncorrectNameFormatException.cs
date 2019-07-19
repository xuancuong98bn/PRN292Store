using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Q1
{
    class IncorrectNameFormatException : SystemException
    {
        public IncorrectNameFormatException() : base("Your input string is incorrect format")
        {

        }
    }
}
