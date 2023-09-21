using FarmVille.Api.Dtos.Statistic;

namespace FarmVille.Api.Services.StatisticServices
{
    public interface IStatisticService
    {
        Task<List<ResultStatisticDto>> GetAllAsync();
        Task<ResultStatisticDto> GetByIdAsync(string id);
        void CreateAsync(CreateStatisticDto StatisticDto);
        void UpdateAsync(UpdateStatisticDto StatisticDto);
        void DeleteAsync(string id);
    }
}
