using AutoMapper;
using FarmVille.Api.Dtos.Testimonial;
using FarmVille.Api.Models;
using FarmVille.Api.Settings;
using MongoDB.Driver;

namespace FarmVille.Api.Services.TestimonialServices
{
    public class TestimonialService : ITestimonialService
    {
        private readonly IMongoCollection<Models.Testimonial> _TestimonialCollection;
        private readonly IMapper _mapper;

        public TestimonialService(IDatabaseSettings _databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _TestimonialCollection = database.GetCollection<Models.Testimonial>(_databaseSettings.TestimonialCollectionName);


            _mapper = mapper;
        }

        public async void CreateAsync(CreateTestimonialDto TestimonialDto)
        {
            var value = _mapper.Map<Testimonial>(TestimonialDto);
            await _TestimonialCollection.InsertOneAsync(value);
        }

        public async void DeleteAsync(string id)
        {
            await _TestimonialCollection.DeleteOneAsync(x => x.TestimonialId == id);
        }

        public async Task<List<ResultTestimonialDto>> GetAllAsync()
        {
            var values = await _TestimonialCollection.Find(x => true).ToListAsync();
            var mappedValue = _mapper.Map<List<ResultTestimonialDto>>(values);
            return mappedValue;

        }

        public async Task<ResultTestimonialDto> GetByIdAsync(string id)
        {
            var values = await _TestimonialCollection.Find<Testimonial>(x => x.TestimonialId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultTestimonialDto>(values);
        }

        public async void UpdateAsync(UpdateTestimonialDto TestimonialDto)
        {
            var values = _mapper.Map<Testimonial>(TestimonialDto);

            var result = await _TestimonialCollection.FindOneAndReplaceAsync(x => x.TestimonialId == TestimonialDto.TestimonialId, values);
        }
    }
}
