using FarmVille.Api.Dtos.AboutUs;

namespace FarmVille.Api.Services.AboutUsServices
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
