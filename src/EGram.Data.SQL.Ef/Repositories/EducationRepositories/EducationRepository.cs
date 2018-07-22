using System;
using EGram.Data.SQL.Ef.Contexts;
using EGram.Data.SQL.Ef.Models;
using EGram.Data.SQL.Ef.Repositories.BaseRepositories;

namespace EGram.Data.SQL.Ef.Repositories.EducationRepositories
{
    public class EducationRepository: BaseRepository<Education>, IEducationRepository, IDisposable
    {
        public EducationRepository(EGramContext context)
            : base(context)
        {
        }


        public EGramContext EGramContext
        {
            //_context is inherited from base of this class and casting it Repository for simplicity
            get { return Context as EGramContext; }
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }        
    }
}
