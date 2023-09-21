using FarmVille.Api.Dtos.Home;
using FarmVille.Api.Services.HomeServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly IHomeService _homeService;

        public HomeController(IHomeService homeService)
        {
            _homeService = homeService;
        }

        [HttpGet]
        public IActionResult GetList() 
        {
            return Ok(_homeService.GetAllAsync());
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetById(string id) 
        {
            return Ok(_homeService.GetByIdAsync(id));
        }
        [HttpPost]
        public IActionResult Create(CreateHomeDto dto)
        {
            _homeService.CreateAsync(dto);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateHomeDto homeDto)
        {
            _homeService.UpdateAsync(homeDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteById(string id) 
        {
            _homeService.DeleteAsync(id);
            return Ok();
        }

    }
}
