using FarmVille.Api.Dtos.AboutUs;
using FarmVille.Api.Services.AboutUsServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _AboutUsService;

        public AboutUsController(IAboutUsService AboutUsService)
        {
            _AboutUsService = AboutUsService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_AboutUsService.GetAllAsync());
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(_AboutUsService.GetByIdAsync(id));
        }
        [HttpPost]
        public IActionResult Create(CreateAboutUsDto dto)
        {
            _AboutUsService.CreateAsync(dto);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateAboutUsDto AboutUsDto)
        {
            _AboutUsService.UpdateAsync(AboutUsDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteById(string id)
        {
            _AboutUsService.DeleteAsync(id);
            return Ok();
        }
    }
}
