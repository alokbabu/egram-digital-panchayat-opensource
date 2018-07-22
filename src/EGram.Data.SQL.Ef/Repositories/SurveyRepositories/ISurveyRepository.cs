using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EGram.Data.EF.Models;
using EGram.Data.EF.Repositories.BaseRepositories;

namespace EGram.Data.EF.Repositories.SurveyRepositories
{
    public interface ISurveyRepository: IBaseRepository<Survey>, IDisposable
    {

    }
}
