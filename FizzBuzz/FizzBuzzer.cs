using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    public class FizzBuzzer
    {
        public string Get(int input)
        {
            if (isMultipleOf3And5(input))
            {
                return "FizzBuzz";
            }
            if (isMultipleOf3(input))
            {
                return "Fizz";
            }
            if (isMultipleOf5(input))
            {
                return "Buzz";
            }

            return input.ToString();
        }

        private bool isMultipleOf3(int input)
        {
            return input % 3 == 0;
        }

        private bool isMultipleOf5(int input)
        {
            return input % 5 == 0;
        }//reflection

        private bool isMultipleOf3And5(int input)
        {
            return isMultipleOf3(input) && isMultipleOf5(input);
        }
    }
}
