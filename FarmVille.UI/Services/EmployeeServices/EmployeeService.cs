using AutoMapper;
using FarmVille.UI.Dtos.Employee;
using FarmVille.UI.Models;
using FarmVille.UI.Settings;
using MongoDB.Driver;

namespace FarmVille.UI.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IMongoCollection<Models.Employee> _EmployeeCollection;
        private readonly IMapper _mapper;

        public EmployeeService(IDatabaseSettings _databaseSettings, IMapper mapper)
        {
            var client = new MongoClient(_databaseSettings.ConnectionString);
            var database = client.GetDatabase(_databaseSettings.DatabaseName);
            _EmployeeCollection = database.GetCollection<Models.Employee>(_databaseSettings.EmployeeCollectionName);


            _mapper = mapper;
        }

        public async void CreateAsync(CreateEmployeeDto EmployeeDto)
        {
            var value = _mapper.Map<Employee>(EmployeeDto);
            await _EmployeeCollection.InsertOneAsync(value);
        }

        public async void DeleteAsync(string id)
        {
            await _EmployeeCollection.DeleteOneAsync(x => x.EmployeeId == id);
        }

        public async Task<List<ResultEmployeeDto>> GetAllAsync()
        {
            var values = await _EmployeeCollection.Find(x => true).ToListAsync();
            var mappedValue = _mapper.Map<List<ResultEmployeeDto>>(values);
            return mappedValue;

        }

        public async Task<ResultEmployeeDto> GetByIdAsync(string id)
        {
            var values = await _EmployeeCollection.Find<Employee>(x => x.EmployeeId == id).FirstOrDefaultAsync();
            return _mapper.Map<ResultEmployeeDto>(values);
        }

        public async void UpdateAsync(UpdateEmployeeDto EmployeeDto)
        {
            var values = _mapper.Map<Employee>(EmployeeDto);

            var result = await _EmployeeCollection.FindOneAndReplaceAsync(x => x.EmployeeId == EmployeeDto.EmployeeId, values);
        }
    }
}
