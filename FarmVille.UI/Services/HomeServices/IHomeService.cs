using FarmVille.UI.Dtos.Home;

namespace FarmVille.UI.Services.HomeServices
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
