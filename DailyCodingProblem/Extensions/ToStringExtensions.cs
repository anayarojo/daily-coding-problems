using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DailyCodingProblem.Extensions
{
    public static class ToStringExtensions
    {
        public static string ArrayToString(this Array array)
        {
            return "[ " + array.JoinEnumerable(", ") + " ]";
        }

        private static string JoinEnumerable(this IEnumerable enumerable, string separator = "")
        {
            var stringBuilder = new StringBuilder();
            var index = 0;

            foreach (var item in enumerable)
            {
                if (index > 0)
                {
                    stringBuilder.Append(separator);
                }

                stringBuilder.Append(item.ToString());

                index++;
            }

            return stringBuilder.ToString();
        }


    }
}