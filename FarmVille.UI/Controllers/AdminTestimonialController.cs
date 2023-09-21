using FarmVille.UI.Dtos.Testimonial;
using FarmVille.UI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.Controllers
{
    public class AdminTestimonialController : Controller
    {
        private readonly ITestimonialService _TestimonialService;

        public AdminTestimonialController(ITestimonialService TestimonialService)
        {
            _TestimonialService = TestimonialService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateTestimonialDto TestimonialDto)
        {
            _TestimonialService.CreateAsync(TestimonialDto);
            return View();
        }
    }
}
