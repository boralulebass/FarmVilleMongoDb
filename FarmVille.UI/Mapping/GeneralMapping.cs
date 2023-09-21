using AutoMapper;
using FarmVille.UI.Dtos.AboutUs;
using FarmVille.UI.Dtos.Employee;
using FarmVille.UI.Dtos.Home;
using FarmVille.UI.Dtos.Statistic;
using FarmVille.UI.Dtos.Testimonial;
using FarmVille.UI.Models;

namespace FarmVille.UI.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping() 
        {
           CreateMap<ResultHomeDto, Home>().ReverseMap();
           CreateMap<CreateHomeDto, Home>().ReverseMap();
           CreateMap<UpdateHomeDto, Home>().ReverseMap();

           CreateMap<ResultAboutUsDto, AboutUs>().ReverseMap();
           CreateMap<UpdateAboutUsDto, AboutUs>().ReverseMap();
           CreateMap<CreateAboutUsDto, AboutUs>().ReverseMap();

           CreateMap<ResultStatisticDto, Statistic>().ReverseMap();
           CreateMap<UpdateStatisticDto, Statistic>().ReverseMap();
           CreateMap<CreateStatisticDto, Statistic>().ReverseMap();

           CreateMap<ResultTestimonialDto, Testimonial>().ReverseMap();
           CreateMap<UpdateTestimonialDto, Testimonial>().ReverseMap();
           CreateMap<CreateTestimonialDto, Testimonial>().ReverseMap();

           CreateMap<UpdateEmployeeDto, Employee>().ReverseMap();
           CreateMap<CreateEmployeeDto, Employee>().ReverseMap();
           CreateMap<ResultEmployeeDto, Employee>().ReverseMap();

        }
    }
}
