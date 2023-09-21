using FarmVille.UI.Services.HomeServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _WhyUsPartial : ViewComponent
    {
        private readonly IHomeService _homeService;

        public _WhyUsPartial(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _homeService.GetByIdAsync("650b8190f2295dd62f22056f");
            return View(value);
        }
    }
}
