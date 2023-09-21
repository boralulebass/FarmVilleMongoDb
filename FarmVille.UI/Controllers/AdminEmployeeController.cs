using FarmVille.UI.Dtos.Employee;
using FarmVille.UI.Services.EmployeeServices;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.UI.Controllers
{
    public class AdminEmployeeController : Controller
    {
        private readonly IEmployeeService _EmployeeService;

        public AdminEmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CreateEmployeeDto EmployeeDto)
        {
            _EmployeeService.CreateAsync(EmployeeDto);
            return View();
        }
    }
}
