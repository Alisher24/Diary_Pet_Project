using AutoMapper;
using Diary_Pet_Procejct.Domain.Entity;
using Diary_Pet_Project.Domain.Dto.Report;

namespace Diary_Pet_Project.Application.Mapping
{
    public class ReportMapping : Profile
    {
        public ReportMapping() 
        {
            CreateMap<Report, ReportDto>().ReverseMap();
        }
    }
}
