using FarmVille.UI.Models;
using FarmVille.UI.Services.AboutUsServices;
using FarmVille.UI.Services.HomeServices;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FarmVille.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public IActionResult Index()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View();
        }
    }
}