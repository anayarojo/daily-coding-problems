using DailyCodingProblem.CodingProblems;
using FluentAssertions;
using NUnit.Framework;

namespace DailyCodingProblem.UnitTests
{
    public class Tests
    {
        [Test]
        public void Should_Return_ProductOfAllOtherElements()
        {
            var inputNumbersA = new int[] {1, 2, 3, 4, 5};
            var outputNumbersA = new int[] {120, 60, 40, 30, 24};

            var resultA = Arrays.GetProductOfAllOtherElements(inputNumbersA);
            resultA.Should().Equal(outputNumbersA);

            var inputNumbersB = new int[] { 3, 2, 1 };
            var outputNumbersB = new int[] { 2, 3, 6 };

            var resultB = Arrays.GetProductOfAllOtherElements(inputNumbersB);
            resultB.Should().Equal(outputNumbersB);
        }
    }
}