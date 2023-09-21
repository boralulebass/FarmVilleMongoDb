using FarmVille.Api.Dtos.Testimonial;
using FarmVille.Api.Services.TestimonialServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialController : ControllerBase
    {
        private readonly ITestimonialService _TestimonialService;

        public TestimonialController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_TestimonialService.GetAllAsync());
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(_TestimonialService.GetByIdAsync(id));
        }
        [HttpPost]
        public IActionResult Create(CreateTestimonialDto dto)
        {
            _TestimonialService.CreateAsync(dto);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateTestimonialDto TestimonialDto)
        {
            _TestimonialService.UpdateAsync(TestimonialDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteById(string id)
        {
            _TestimonialService.DeleteAsync(id);
            return Ok();
        }
    }
}
