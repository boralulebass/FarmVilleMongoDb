using FarmVille.UI.Services.HomeServices;
using FarmVille.UI.Services.TestimonialServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _TestimonialPartial : ViewComponent
    {
        private readonly ITestimonialService _testimonialService;

        public _TestimonialPartial(ITestimonialService testimonialService)
        {
            _testimonialService = testimonialService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _testimonialService.GetByIdAsync("650b8266a86c804e19f65f7c");
            return View(value);
        }
    }
}
