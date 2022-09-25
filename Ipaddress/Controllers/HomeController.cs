using Ipaddress.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Ipaddress.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private IHttpContextAccessor _accessor;
        public HomeController(ILogger<HomeController> logger, IHttpContextAccessor accessor)
        {
            _accessor = accessor;
            _logger = logger;
        }

        public IActionResult Index()
        {
            string ipAddress = _accessor.HttpContext.Connection.RemoteIpAddress.ToString();
            ViewBag.IPAddress = ipAddress;
            return View();
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
