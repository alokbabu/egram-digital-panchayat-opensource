using System;
using System.Threading.Tasks;
using EGram.Data.SQL.Ef.Contexts;
using EGram.Data.EF.Repositories.SurveyRepositories;

namespace EGram.Data.SQL.Ef.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly Context _context;

        public ISurveyRepository Surveys { get; private set; }

        public UnitOfWork(Context context, ISurveyRepository surveyRepository)
        {
            _context = context;
            Surveys = new SurveyRepository(_context);
        }

        public Task<int> Complete()
        {
            return _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
