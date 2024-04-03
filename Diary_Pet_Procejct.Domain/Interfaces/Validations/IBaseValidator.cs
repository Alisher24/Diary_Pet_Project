using Diary_Pet_Project.Domain.Result;

namespace Diary_Pet_Project.Domain.Interfaces.Validations
{
    public interface IBaseValidator<T> where T : class
    {
        BaseResult ValidateOnNull(T model);
    }
}
