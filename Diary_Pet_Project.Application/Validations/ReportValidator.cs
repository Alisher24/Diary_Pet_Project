using Diary_Pet_Procejct.Domain.Entity;
using Diary_Pet_Project.Application.Resources;
using Diary_Pet_Project.Domain.Enum;
using Diary_Pet_Project.Domain.Interfaces.Validations;
using Diary_Pet_Project.Domain.Result;

namespace Diary_Pet_Project.Application.Validations
{
    public class ReportValidator : IReportValidator
    {
        public BaseResult CreateValidator(Report report, User user)
        {
            if (report != null)
            {
                return new BaseResult()
                {
                    ErrorMessage = ErrorMessage.ReportAlreadyExists,
                    ErrorCode = (int)ErrorCodes.ReportAlreadyExists
                };
            }

            if (user == null)
            {
                return new BaseResult()
                {
                    ErrorMessage = ErrorMessage.UserNotFound,
                    ErrorCode = (int)ErrorCodes.UserNotFound
                };
            }

            return new BaseResult();
        }

        public BaseResult ValidateOnNull(Report model)
        {
            if (model == null)
            {
                return new BaseResult()
                {
                    ErrorMessage = ErrorMessage.ReportNotFound,
                    ErrorCode = (int)ErrorCodes.ReportNotFound
                };
            }

            return new BaseResult();
        }
    }
}
