using Diary_Pet_Project.Domain.Dto;
using Diary_Pet_Project.Domain.Result;

namespace Diary_Pet_Project.Domain.Interfaces.Services
{
    /// <summary>
    /// Сервис отвечающий за работу с доменной части отчета (Report)
    /// </summary>
    public interface IReportService
    {
        /// <summary>
        /// Получение всех отчетов пользователя
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        Task<CollectionResult<ReportDto>> GetReportsAsync(long userId);
    }
}
