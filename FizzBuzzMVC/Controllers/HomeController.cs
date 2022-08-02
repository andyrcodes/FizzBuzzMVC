using FizzBuzzMVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FizzBuzzMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var model = new FBModel();
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(FBModel model)
        {
            for (int i = model.StartNum; i <= model.EndNum; i++)
            {
                if (i % model.FizzNum == 0 && i % model.BuzzNum == 0)
                {
                    model.Results.Add("FizzBuzz");
                }
                else if (i % model.FizzNum == 0)
                {
                    model.Results.Add("Fizz");
                }
                else if (i % model.BuzzNum == 0)
                {
                    model.Results.Add("Buzz");
                }
                else
                {
                    model.Results.Add(i.ToString());
                }
            }
            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
