using FarmVille.UI.Services.AboutUsServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _AboutWhyUsPartial : ViewComponent
    {
        private readonly IAboutUsService _aboutUsService;

        public _AboutWhyUsPartial(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _aboutUsService.GetByIdAsync("650b837435144cc7ef809e79");
            return View(value);
        }
    }
}
