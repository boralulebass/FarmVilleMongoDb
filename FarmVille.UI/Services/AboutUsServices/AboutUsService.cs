using AutoMapper;
using FarmVille.UI.Dtos.AboutUs;
using FarmVille.UI.Models;
using FarmVille.UI.Settings;
using MongoDB.Driver;

namespace FarmVille.UI.Services.AboutUsServices
{
    public class AboutUsService : IAboutUsService
    {
        private readonly IMongoCollection<AboutUs> _AboutUsCollection;
        private readonly IMapper _mapper;

        public AboutUsService(IDatabaseSettings _databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _AboutUsCollection = database.GetCollection<Models.AboutUs>(_databaseSettings.AboutUsCollectionName);


            _mapper = mapper;
        }

        public async void CreateAsync(CreateAboutUsDto AboutUsDto)
        {
            var value = _mapper.Map<AboutUs>(AboutUsDto);
            await _AboutUsCollection.InsertOneAsync(value);
        }

        public async void DeleteAsync(string id)
        {
            await _AboutUsCollection.DeleteOneAsync(x=>x.AboutUsId == id);
        }

        public async Task<List<ResultAboutUsDto>> GetAllAsync()
        {
            var values = await _AboutUsCollection.Find(x => true).ToListAsync();
            var mappedValue =_mapper.Map<List<ResultAboutUsDto>>(values);
            return mappedValue;
            
        }

        public async Task<ResultAboutUsDto> GetByIdAsync(string id)
        {
            var values = await _AboutUsCollection.Find<AboutUs>(x => x.AboutUsId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultAboutUsDto>(values);
        }

        public async void UpdateAsync(UpdateAboutUsDto AboutUsDto)
        {
            var values = _mapper.Map<AboutUs>(AboutUsDto);

            var result = await _AboutUsCollection.FindOneAndReplaceAsync(x => x.AboutUsId == AboutUsDto.AboutUsId, values);
        }
    }
}
