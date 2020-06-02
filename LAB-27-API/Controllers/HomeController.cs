using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using LAB_27_API.Models;

namespace LAB_27_API.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        private readonly RedditDal RD = new RedditDal();

        public IActionResult Index()
        {
            RedditDal AwwDal = new RedditDal();
            Aww aww = AwwDal.GetAww();
            return View(aww);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Subreddit()
        {
            //string output = RD.GetAPIString("aww");
            //ViewBag.test = output;

            Aww rp = RD.GetAww();
            return View(rp);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
