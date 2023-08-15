using com.olfonet.by.Controllers;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Net.Mail;
using System.Net;


namespace com.olfonet.by.Controllers
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

            return View();
        }

        public IActionResult Service()
        {
            return View();
        }

        public IActionResult Abonent()
        {
            return View();
        }

        public IActionResult ITstandart()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        

    }
}