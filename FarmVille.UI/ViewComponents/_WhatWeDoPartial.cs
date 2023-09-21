using FarmVille.UI.Services.HomeServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _WhatWeDoPartial : ViewComponent
    {
        private readonly IHomeService _homeService;

        public _WhatWeDoPartial(IHomeService homeService)
        {
            _homeService = homeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var value = await _homeService.GetByIdAsync("650b80bef2295dd62f22056d");
            return View(value);
        }
    }
}
