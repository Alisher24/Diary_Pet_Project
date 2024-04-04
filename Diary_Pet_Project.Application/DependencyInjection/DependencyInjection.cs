using Diary_Pet_Project.Application.Mapping;
using Diary_Pet_Project.Application.Services;
using Diary_Pet_Project.Application.Validations;
using Diary_Pet_Project.Application.Validations.FluentValidations.Report;
using Diary_Pet_Project.Domain.Dto.Report;
using Diary_Pet_Project.Domain.Interfaces.Services;
using Diary_Pet_Project.Domain.Interfaces.Validations;
using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

namespace Diary_Pet_Project.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ReportMapping));

            InitServices(services);
        }

        private static void InitServices(this IServiceCollection services)
        {
            services.AddScoped<IReportValidator, ReportValidator>();
            services.AddScoped<IValidator<CreateReportDto>, CreateReportValidator>();
            services.AddScoped<IValidator<UpdateReportDto>, UpdateReportValidator>();

            services.AddScoped<IReportService, ReportService>();
        }
    }
}
