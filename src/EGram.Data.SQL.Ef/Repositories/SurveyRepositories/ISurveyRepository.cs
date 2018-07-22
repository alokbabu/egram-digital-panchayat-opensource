using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EGram.Data.SQL.Ef.Models;
using EGram.Data.SQL.Ef.Repositories.BaseRepositories;

namespace EGram.Data.EF.Repositories.SurveyRepositories
{
    public interface ISurveyRepository: IBaseRepository<Survey>, IDisposable
    {

    }
}
