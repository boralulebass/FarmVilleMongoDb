using FarmVille.Api.Dtos.Employee;
using FarmVille.Api.Services.EmployeeServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FarmVille.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _EmployeeService;

        public EmployeeController(IEmployeeService EmployeeService)
        {
            _EmployeeService = EmployeeService;
        }

        [HttpGet]
        public IActionResult GetList()
        {
            return Ok(_EmployeeService.GetAllAsync());
        }
        [HttpGet("[action]/{id}")]
        public IActionResult GetById(string id)
        {
            return Ok(_EmployeeService.GetByIdAsync(id));
        }
        [HttpPost]
        public IActionResult Create(CreateEmployeeDto dto)
        {
            _EmployeeService.CreateAsync(dto);
            return Ok();
        }
        [HttpPut]
        public IActionResult Update(UpdateEmployeeDto EmployeeDto)
        {
            _EmployeeService.UpdateAsync(EmployeeDto);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteById(string id)
        {
            _EmployeeService.DeleteAsync(id);
            return Ok();
        }
    }
}
