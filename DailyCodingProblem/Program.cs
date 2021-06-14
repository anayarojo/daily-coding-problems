using DailyCodingProblem.CodingProblems;
using DailyCodingProblem.Extensions;
using System;

namespace DailyCodingProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbersA = new int[] { 1, 2, 3, 4, 5 };
            var outputNumbersA = new int[] { 120, 60, 40, 30, 24 };
             var resultA = Arrays.GetProductOfAllOtherElements(inputNumbersA);
            
            Console.WriteLine(inputNumbersA.ArrayToString());
            Console.WriteLine(outputNumbersA.ArrayToString());
            Console.WriteLine(resultA.ArrayToString());
        }
    }
}
