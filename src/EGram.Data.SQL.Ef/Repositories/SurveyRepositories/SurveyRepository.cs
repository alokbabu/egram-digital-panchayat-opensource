using System;
using EGram.Data.SQL.Ef.Contexts;
using EGram.Data.SQL.Ef.Models;
using EGram.Data.SQL.Ef.Repositories.BaseRepositories;

namespace EGram.Data.EF.Repositories.SurveyRepositories
{
    public class SurveyRepository: BaseRepository<Survey>, ISurveyRepository, IDisposable
    {
        public SurveyRepository(Context context)
            :base(context)
        {
        }


        public Context EGramContext
        {
            //_context is inherited from base of this class and casting it Repository for simplicity
            get { return EGramContext as Context; }
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
