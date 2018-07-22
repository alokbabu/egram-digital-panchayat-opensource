using System;
using System.Threading.Tasks;
using EGram.Data.SQL.Ef.Contexts;
using EGram.Data.EF.Repositories.SurveyRepositories;
using EGram.Data.SQL.Ef.Repositories.EducationRepositories;

namespace EGram.Data.SQL.Ef.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly EGramContext _context;

        public ISurveyRepository Surveys { get; private set; }
        public IEducationRepository Educations { get; private set; }

        public UnitOfWork(EGramContext context)
        {
            if(context == null)
            {
                throw new Exception("Context cannot be null");
            }
            _context = context;
            Surveys = new SurveyRepository(_context);
            Educations = new EducationRepository(_context);
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
