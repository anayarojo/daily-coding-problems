using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyCodingProblem.CodingProblems
{
    public static class Arrays
    {
        public static int[] GetProductOfAllOtherElements(int[] numbers)
        {
            // Generate prefix products
            var prefixProducts = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    prefixProducts[i] = numbers[i];
                }
                else
                {
                    prefixProducts[i] = prefixProducts[i - 1] * numbers[i];
                }
            }

            // Generate suffix products
            var suffixProducts = new int[numbers.Length];

            Array.Reverse(numbers);

            for (var i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    suffixProducts[i] = numbers[i];
                }
                else
                {
                    suffixProducts[i] = suffixProducts[i - 1] * numbers[i];
                }
            }
            
            Array.Reverse(suffixProducts);
            Array.Reverse(numbers);

            // Generate result from the product of prefixes and suffixes

            var result = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (i == 0)
                {
                    result[i] = suffixProducts[i + 1];
                }
                else if (i == numbers.Length - 1)
                {
                    result[i] = prefixProducts[i - 1];
                }
                else
                {
                    result[i] = prefixProducts[i - 1] * suffixProducts[i + 1];
                }
            }

            return result;
        }
    }
}
