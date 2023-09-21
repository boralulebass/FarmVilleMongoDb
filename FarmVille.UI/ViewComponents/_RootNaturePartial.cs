using FarmVille.UI.Services.HomeServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _RootNaturePartial : ViewComponent
    {
        private readonly IHomeService _homeService;

        public _RootNaturePartial(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _homeService.GetByIdAsync("650b812cf2295dd62f22056e");
            return View(value);
        }
    }
}
