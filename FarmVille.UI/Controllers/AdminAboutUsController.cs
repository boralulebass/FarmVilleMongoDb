using FarmVille.UI.Dtos.AboutUs;
using FarmVille.UI.Services.AboutUsServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.Controllers
{
    public class AdminAboutUsController : Controller
    {
        private readonly IAboutUsService _AboutUsService;

        public AdminAboutUsController(IAboutUsService AboutUsService)
        {
            _AboutUsService = AboutUsService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateAboutUsDto AboutUsDto)
        {
            _AboutUsService.CreateAsync(AboutUsDto);
            return View();
        }
    }
}
