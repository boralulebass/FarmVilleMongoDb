using FarmVille.Api.Dtos.Home;

namespace FarmVille.Api.Services.HomeServices
{
    public interface IHomeService
    {
        Task<List<ResultHomeDto>> GetAllAsync();
        Task<ResultHomeDto> GetByIdAsync(string id);
        void CreateAsync(CreateHomeDto homeDto);
        void UpdateAsync(UpdateHomeDto homeDto);
        void DeleteAsync(string id);
    }
}
