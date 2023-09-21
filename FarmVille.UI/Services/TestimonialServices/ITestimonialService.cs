using FarmVille.UI.Dtos.Testimonial;

namespace FarmVille.UI.Services.TestimonialServices
{
    public interface ITestimonialService
    {
        Task<List<ResultTestimonialDto>> GetAllAsync();
        Task<ResultTestimonialDto> GetByIdAsync(string id);
        void CreateAsync(CreateTestimonialDto TestimonialDto);
        void UpdateAsync(UpdateTestimonialDto TestimonialDto);
        void DeleteAsync(string id);
    }
}
