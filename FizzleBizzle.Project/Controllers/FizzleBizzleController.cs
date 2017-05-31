using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FizzleBizzle.Project.Factories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FizzleBizzle.Project.Controllers
{
    public class FizzleBizzleController : Controller
    {
        [Route("/api/FizzBuzz/{fizz}/{buzz}/{start}/{end}")]
        public IEnumerable<string> GetFizzBuzz(int fizz, int buzz, int start, int end)
        {
            return new Services.FizzleBizzle(fizz, buzz).FizzBuzz(start, end);
        }

        [Route("/api/FizzBuzzBazz/{fizz}/{buzz}/{bazz}/{op}/{start}/{end}")]
        public IEnumerable<string> GetFizzBuzzBazz(int fizz, int buzz, int bazz, string op, int start, int end)
        {
            var predicateFactory = new PredicateFactory(op, bazz);
            return new Services.FizzleBizzle(fizz, buzz).FizzBuzzBazz(start, end, predicateFactory.ConstructPredicate());
        }
    }
}
