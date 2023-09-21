using AutoMapper;
using FarmVille.Api.Dtos.AboutUs;
using FarmVille.Api.Dtos.Employee;
using FarmVille.Api.Dtos.Home;
using FarmVille.Api.Dtos.Statistic;
using FarmVille.Api.Dtos.Testimonial;
using FarmVille.Api.Models;

namespace FarmVille.Api.Mapping
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
