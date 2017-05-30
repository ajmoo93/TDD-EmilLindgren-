using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class Calculator
    {
        public int Add(string input)
        {

            int Result = 0;
            var delemiters = new List<char>() { ',', '\n', '/', ';' };
            if (input.Length == 0)
            {
                return 0;
            }
            //string[] _numbers = delemiters.Split(',');

            //foreach(var number in _numbers)
            //{
            //    delemiters.Add(int.Parse(input));
            //}
            var numbers = input.ToCharArray().Where(x => !delemiters.Contains(x)).ToList();
            //var numbers = int.Parse(input);
            //if (input.Any(x => x == '-'))
            //{
            //    StringBuilder sb = new StringBuilder();

            //    for (int i = 0; i <= 8; i++)
            //    {
            //        if (numbers[i] == '-')
            //        {
            //            sb.Append('-');
            //            sb.Append(numbers[i++]);
            //            sb.Append(',');
            //        }
            //    }


            //}
            
            foreach(char number in numbers)
            {
                if(number.Equals("-"))
                    
                throw new NegativNotAllowed();
                

            }
            var sum = numbers.Sum(x => (int)Char.GetNumericValue(x));
            
            return sum;


            //if (input[0] == '/')
            //{
            //    var delimiter = input[2];
            //    delemiters.add(delimiter);
            //}


            //return Result;
        }
    }
}
