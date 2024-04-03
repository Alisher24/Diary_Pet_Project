using Diary_Pet_Procejct.Domain.Entity;
using Diary_Pet_Project.Domain.Result;

namespace Diary_Pet_Project.Domain.Interfaces.Validations
{
    public interface IReportValidator : IBaseValidator<Report>
    {
        /// <summary>
        /// Проверяется наличие отчета, если отчет с переданным названием есть в БД, то создать отчет нельзя
        /// Проверяется пользователь, если UserId пользователя не найден, то такого пользователя нет
        /// </summary>
        /// <param name="report"></param>
        /// <param name="user"></param>
        /// <returns></returns>
        BaseResult CreateValidator(Report report, User user);
    }
}
