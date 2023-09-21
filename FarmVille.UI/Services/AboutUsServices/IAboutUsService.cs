using FarmVille.UI.Dtos.AboutUs;

namespace FarmVille.UI.Services.AboutUsServices
{
    public interface IAboutUsService
    {
        Task<List<ResultAboutUsDto>> GetAllAsync();
        Task<ResultAboutUsDto> GetByIdAsync(string id);
        void CreateAsync(CreateAboutUsDto AboutUsDto);
        void UpdateAsync(UpdateAboutUsDto AboutUsDto);
        void DeleteAsync(string id);
    }
}
