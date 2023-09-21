using FarmVille.UI.Services.EmployeeServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.ViewComponents
{
    public class _EmployeePartial : ViewComponent
    {
        private readonly IEmployeeService _employeeService;

        public _EmployeePartial(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = await _employeeService.GetAllAsync();
            return View(values);
        }
    }
}
