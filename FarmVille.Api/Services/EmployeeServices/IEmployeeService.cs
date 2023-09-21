using FarmVille.Api.Dtos.Employee;

namespace FarmVille.Api.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        Task<List<ResultEmployeeDto>> GetAllAsync();
        Task<ResultEmployeeDto> GetByIdAsync(string id);
        void CreateAsync(CreateEmployeeDto EmployeeDto);
        void UpdateAsync(UpdateEmployeeDto EmployeeDto);
        void DeleteAsync(string id);
    }
}
