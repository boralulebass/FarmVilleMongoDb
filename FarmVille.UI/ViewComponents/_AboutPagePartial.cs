using FarmVille.UI.Services.AboutUsServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _AboutPagePartial : ViewComponent
    {
        private readonly IAboutUsService _aboutUsService;

        public _AboutPagePartial(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _aboutUsService.GetByIdAsync("650b832235144cc7ef809e78");
            return View(value);
        }
    }
}
