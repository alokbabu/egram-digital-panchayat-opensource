using System;
using System.Threading.Tasks;
using EGram.Data.EF.Repositories.SurveyRepositories;
using EGram.Data.SQL.Ef.Repositories.EducationRepositories;

namespace EGram.Data.SQL.Ef.Repositories
{
    public interface IUnitOfWork: IDisposable
    {
        ISurveyRepository Surveys { get; }
        IEducationRepository Educations { get; }
        Task<int> Complete();
    }
}
