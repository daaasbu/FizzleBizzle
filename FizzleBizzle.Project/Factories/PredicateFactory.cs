using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzleBizzle.Project.Extensions;

namespace FizzleBizzle.Project.Factories
{
    public class PredicateFactory
    {
        private Func<int, Func<int, bool>> op {get; set;}
        private int n { get; set; }

        public PredicateFactory(string op, int n)
        {
            Func<int, Func<int, bool>> opFunc;
            bool result = Lambda.TryParse(op, out opFunc);

            if (!result) throw new FormatException();

            this.op = opFunc;
            this.n = n; 
        }
        /// <summary>
        /// ConstructPredicate builds a predicate from the supplied n and op
        /// </summary>
        /// <returns></returns>
        public Predicate<int> ConstructPredicate()
        {
            return new Predicate<int>(op(n));
        }
    }
}
