using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace FizzleBizzle.Project.Extensions
{
    public static class IntExtensions
    {
        /// <summary>
        /// IsDivisible is an integer extension method which returns true if and only if a is evenly divisible by n.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public static bool IsDivisible(this int a, int n)
        {
            return (a % n) == 0;
        }

    }
}
