using System;
using EGram.Data.SQL.Ef.Models;
using EGram.Data.SQL.Ef.Repositories.BaseRepositories;

namespace EGram.Data.SQL.Ef.Repositories.EducationRepositories
{
    public interface IEducationRepository: IBaseRepository<Education>, IDisposable
    {
        
    }
}
