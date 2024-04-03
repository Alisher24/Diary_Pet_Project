using Diary_Pet_Project.Domain.Dto.Report;
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

        /// <summary>
        /// Получение отчета по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<BaseResult<ReportDto>> GetReportByIdAsync(long id);

        /// <summary>
        /// Создание отчета с базовыми парамаетрами
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<BaseResult<ReportDto>> CreateReportAsync(CreateReportDto dto);

        /// <summary>
        /// Удаление отчета по id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<BaseResult<ReportDto>> DeleteReportAsync(long id);

        /// <summary>
        /// Обновление отчета
        /// </summary>
        /// <param name="dto"></param>
        /// <returns></returns>
        Task<BaseResult<ReportDto>> UpdateReportAsync(UpdateReportDto dto);
    }
}
