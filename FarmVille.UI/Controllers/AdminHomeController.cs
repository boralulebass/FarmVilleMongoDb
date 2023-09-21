using FarmVille.UI.Dtos.Home;
using FarmVille.UI.Services.HomeServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.Controllers
{
    public class AdminHomeController : Controller
    {
        private readonly IHomeService _homeService;

        public AdminHomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateHomeDto homeDto)
        {
            _homeService.CreateAsync(homeDto);
            return View();
        }
    }
}
