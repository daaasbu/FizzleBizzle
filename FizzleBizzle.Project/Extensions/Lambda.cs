using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FizzleBizzle.Project.Extensions
{
    public static class Lambda
    {
        /// <summary>
        /// TryParse attempts to parse string into operator. If a valid operator,
        /// it will perform Eta Expansion on the operator and set the output variable as that function
        /// and return true, otherwise will set it to null and return false.
        /// </summary>
        /// <param name="s"></param>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool TryParse(string s, out Func<int, Func<int,bool>> result)
        {
            switch(s)
            {
                case ">=":
                    result = (x) => (y) => x >= y;
                    return true;
                case ">":
                    result = (x) => (y) => x > y;
                    return true;
                case "<":
                    result = (x) => (y) => x < y;
                    return true;
                case "<=":
                    result = (x) => (y) => x <= y;
                    return true;
                case "==":
                    result = (x) => (y) => x == y;
                    return true;
                case "!=":
                    result = (x) => (y) => x != y;
                    return true;
                default:
                    result = null;
                    return false;
                
            }
        }
    }
}
