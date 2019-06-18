using System.Linq;
using CodingTest.Models;
using Microsoft.AspNetCore.Mvc;

namespace CodingTest.Controllers
{
    public class FizzBuzzController : Controller
    {
        public IActionResult Index() => View(FizzBuzz.Sequence().Take(100));
    }
}