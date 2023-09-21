using FarmVille.UI.Services.HomeServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _WelcomePartial : ViewComponent
    {
       private readonly IHomeService _homeService;

        public _WelcomePartial(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _homeService.GetByIdAsync("650b7f9ef2295dd62f22056b");
            return View(value);
        }
    }
}
