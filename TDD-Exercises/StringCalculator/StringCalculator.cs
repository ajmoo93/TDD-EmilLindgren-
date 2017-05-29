using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add (string input)
        {

            int Result = 0;
            List<char> delemiters = new List<char>() { ',' };
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }


            return Result;
        }
    }
}
