using FarmVille.UI.Services.HomeServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _AboutUsPartial : ViewComponent
    {
        private readonly IHomeService _homeService;

        public _AboutUsPartial(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _homeService.GetByIdAsync("650b8048f2295dd62f22056c");
            return View(value);
        }
    }
}
