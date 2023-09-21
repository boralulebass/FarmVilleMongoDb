using AutoMapper;
using FarmVille.UI.Dtos.Statistic;
using FarmVille.UI.Models;
using FarmVille.UI.Settings;
using MongoDB.Driver;

namespace FarmVille.UI.Services.StatisticServices
{
    public class StatisticService : IStatisticService
    {
        private readonly IMongoCollection<Models.Statistic> _StatisticCollection;
        private readonly IMapper _mapper;

        public StatisticService(IDatabaseSettings _databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _StatisticCollection = database.GetCollection<Models.Statistic>(_databaseSettings.StatisticCollectionName);


            _mapper = mapper;
        }

        public async void CreateAsync(CreateStatisticDto StatisticDto)
        {
            var value = _mapper.Map<Statistic>(StatisticDto);
            await _StatisticCollection.InsertOneAsync(value);
        }

        public async void DeleteAsync(string id)
        {
            await _StatisticCollection.DeleteOneAsync(x => x.StatisticId == id);
        }

        public async Task<List<ResultStatisticDto>> GetAllAsync()
        {
            var values = await _StatisticCollection.Find(x => true).ToListAsync();
            var mappedValue = _mapper.Map<List<ResultStatisticDto>>(values);
            return mappedValue;

        }

        public async Task<ResultStatisticDto> GetByIdAsync(string id)
        {
            var values = await _StatisticCollection.Find<Statistic>(x => x.StatisticId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultStatisticDto>(values);
        }

        public async void UpdateAsync(UpdateStatisticDto StatisticDto)
        {
            var values = _mapper.Map<Statistic>(StatisticDto);

            var result = await _StatisticCollection.FindOneAndReplaceAsync(x => x.StatisticId == StatisticDto.StatisticId, values);
        }
    }
}
