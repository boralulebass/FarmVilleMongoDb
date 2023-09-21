using FarmVille.UI.Services.AboutUsServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _AboutEmployeePartial : ViewComponent
    {
        private readonly IAboutUsService _aboutUsService;

        public _AboutEmployeePartial(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _aboutUsService.GetByIdAsync("650b83d135144cc7ef809e7a");
            return View(value);
        }
    }
}
