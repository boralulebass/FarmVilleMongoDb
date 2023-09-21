using FarmVille.UI.Dtos.Statistic;
using FarmVille.UI.Services.StatisticServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.Controllers
{
    public class AdminStatisticController : Controller
    {
        private readonly IStatisticService _StatisticService;

        public AdminStatisticController(IStatisticService StatisticService)
        {
            _StatisticService = StatisticService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateStatisticDto StatisticDto)
        {
            _StatisticService.CreateAsync(StatisticDto);
            return View();
        }
    }
}
