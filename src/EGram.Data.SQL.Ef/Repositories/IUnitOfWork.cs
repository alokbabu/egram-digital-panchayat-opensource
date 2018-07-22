using System;
using System.Threading.Tasks;
using EGram.Data.EF.Repositories.SurveyRepositories;

namespace EGram.Data.EF.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        ISurveyRepository Surveys { get; }
        Task<int> Complete();
    }
}
