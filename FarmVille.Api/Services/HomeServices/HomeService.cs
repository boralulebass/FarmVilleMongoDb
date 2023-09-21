using AutoMapper;
using FarmVille.Api.Dtos.Home;
using FarmVille.Api.Models;
using FarmVille.Api.Settings;
using MongoDB.Driver;

namespace FarmVille.Api.Services.HomeServices
{
    public class HomeService : IHomeService
    {
        private readonly IMongoCollection<Models.Home> _homeCollection;
        private readonly IMapper _mapper;

        public HomeService(IDatabaseSettings _databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _homeCollection = database.GetCollection<Models.Home>(_databaseSettings.HomeCollectionName);


            _mapper = mapper;
        }

        public async void CreateAsync(CreateHomeDto homeDto)
        {
            var value = _mapper.Map<Home>(homeDto);
            await _homeCollection.InsertOneAsync(value);
        }

        public async void DeleteAsync(string id)
        {
            await _homeCollection.DeleteOneAsync(x=>x.HomeId == id);
        }

        public async Task<List<ResultHomeDto>> GetAllAsync()
        {
            var values = await _homeCollection.Find(x => true).ToListAsync();
            var mappedValue =_mapper.Map<List<ResultHomeDto>>(values);
            return mappedValue;
            
        }

        public async Task<ResultHomeDto> GetByIdAsync(string id)
        {
            var values = await _homeCollection.Find<Home>(x => x.HomeId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultHomeDto>(values);
        }

        public async void UpdateAsync(UpdateHomeDto homeDto)
        {
            var values = _mapper.Map<Home>(homeDto);

            var result = await _homeCollection.FindOneAndReplaceAsync(x => x.HomeId == homeDto.HomeId, values);
        }
    }
}
