using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzleBizzle.Project.Interfaces;
using FizzleBizzle.Project.Extensions;

namespace FizzleBizzle.Project.Services
{
    public class FizzleBizzle : IFizzleBizzle
    {
        public int Fizz { private get; set; }
        public int Buzz { private get; set; }
    
        public FizzleBizzle(int fizz, int buzz)
        {
            Fizz = fizz;
            Buzz = buzz;
        }

        /// <summary>
        /// FizzBuzzMapper returns the string "FizzBuzz" if n is divisible by both Fizz and Buzz,
        /// it returns "Fizz" if n is divisible by Fizz,
        /// it returns the string "Buzz" if n is divisible by Buzz and
        /// returns n as a string otherwise.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private string FizzBuzzMapper(int n)
        {
            return FizzBuzzBazzMapper(n, x => false);
        }

        /// <summary>
        /// FizzBuzzBazzMapper returns the string "FizzBuzzBazz" if n is divisible by both Fizz and Buzz 
        /// and the predicate bazz applied to fizz returns true,
        /// otherwise it follows the same return values as FizzBuzzMapper.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="bazz"></param>
        /// <returns></returns>
        private string FizzBuzzBazzMapper(int n, Predicate<int> bazz)
        {
            if (n.IsDivisible(Fizz) && n.IsDivisible(Buzz) && bazz(n)) return "FizzBuzzBazz";
            if (n.IsDivisible(Fizz) && n.IsDivisible(Buzz)) return "FizzBuzz";
            if (n.IsDivisible(Fizz)) return "Fizz";
            if (n.IsDivisible(Buzz)) return "Buzz";
            return n.ToString();
        }

        /// <summary>
        /// GetFizzBuzzMapping applies the function mapper to every integer in the range [start, end] 
        /// and returns an array of the mappings.
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="mapper"></param>
        /// <returns></returns>
        private string[] GetFizzBuzzMapping(int start, int end, Func<int, string> mapper)
        {
            return Enumerable.Range(start, end-start+1).Select(n => mapper(n)).ToArray();
        }
        
        /// <summary>
        /// FizzBuzz generates an array of strings representing the consecutive sequence of
        /// integers from start to end. When the integer is a multiple of Fizz, the string
        /// "Fizz" is added instead. Likewise, for multiples of Buzz, "Buzz" is added. For
        /// multiples of both Fizz and Buzz, "FizzBuzz" is added.
        /// (e.g. With Fizz = 3, Buzz = 5, start = 1, and end = 15; the array looks like:
        /// ["1", "2", "Fizz", "4", "Buzz", "Fizz", "7", "8", ... , "14", "FizzBuzz"])
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public string[] FizzBuzz(int start, int end) 
        {
            return GetFizzBuzzMapping(start, end, FizzBuzzMapper);
        }


        /// <summary>
        /// FizzBuzzBazz returns the same result as FizzBuzz, except that instances of "FizzBuzz"
        /// are "FizzBuzzBazz" where the Predicate bazz is true.
        /// (e.g. With Fizz = 2, Buzz = 3, start = 1, end = 15, bazz = (x => x > 6); the array
        /// looks like ["1", "Fizz", "Buzz", "Fizz", "5", "FizzBuzz", "7", "Fizz", "Buzz", "Fizz",
        /// "11", "FizzBuzzBazz", "13", "Fizz", "Buzz"])
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <param name="bazz"></param>
        /// <returns></returns>
        public string[] FizzBuzzBazz(int start, int end, Predicate<int> bazz)
        {
            return GetFizzBuzzMapping(start, end, n => FizzBuzzBazzMapper(n, bazz));
        }
    }
}

