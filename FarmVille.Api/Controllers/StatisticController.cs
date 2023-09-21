using FarmVille.Api.Dtos.Statistic;
using FarmVille.Api.Services.StatisticServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticController : ControllerBase
    {
        private readonly IStatisticService _StatisticService;

        public StatisticController(IStatisticService StatisticService)
        {
            _StatisticService = StatisticService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_StatisticService.GetAllAsync());
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(_StatisticService.GetByIdAsync(id));
        }
        [HttpPost]
        public IActionResult Create(CreateStatisticDto dto)
        {
            _StatisticService.CreateAsync(dto);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateStatisticDto StatisticDto)
        {
            _StatisticService.UpdateAsync(StatisticDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteById(string id)
        {
            _StatisticService.DeleteAsync(id);
            return Ok();
        }
    }
}
