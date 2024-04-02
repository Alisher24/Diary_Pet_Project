using Diary_Pet_Procejct.Domain.Entity;
using Diary_Pet_Project.Application.Resources;
using Diary_Pet_Project.Domain.Dto;
using Diary_Pet_Project.Domain.Enum;
using Diary_Pet_Project.Domain.Interfaces.Repositories;
using Diary_Pet_Project.Domain.Interfaces.Services;
using Diary_Pet_Project.Domain.Result;
using Microsoft.EntityFrameworkCore;
using Serilog;

namespace Diary_Pet_Project.Application.Services
{
    public class ReportService : IReportService
    {
        private readonly IBaseRepository<Report> _reportRepository;
        private readonly ILogger _logger;

        public ReportService(IBaseRepository<Report> reportRepository)
        {
            _reportRepository = reportRepository;
        }

        public async Task<CollectionResult<ReportDto>> GetReportsAsync(long userId)
        {
            ReportDto[] reports;
            try
            {
                reports = await _reportRepository.GetAll()
                    .Where(x => x.UserId == userId)
                    .Select(x => new ReportDto(x.Id, x.Name, x.Description, x.CreatedAt.ToLongDateString()))
                    .ToArrayAsync();
            }
            catch (Exception ex)
            {
                _logger.Error(ex, ex.Message);
                return new CollectionResult<ReportDto>()
                {
                    ErrorMessage = ErrorMessage.InternalServerError,
                    ErrorCode = (int)ErrorCodes.InternalServerError
                };
            }
            
            if (!reports.Any())
            {
                _logger.Warning(ErrorMessage.ReportsNotFound, reports.Length);
                return new CollectionResult<ReportDto>()
                {
                    ErrorMessage = ErrorMessage.ReportsNotFound,
                    ErrorCode = (int)ErrorCodes.ReportsNotFound
                };
            }

            return new CollectionResult<ReportDto>()
            {
                Data = reports,
                Count = reports.Length
            };
        }
    }
}
