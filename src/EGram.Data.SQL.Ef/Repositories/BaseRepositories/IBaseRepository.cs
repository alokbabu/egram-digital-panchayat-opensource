﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace EGram.Data.SQL.Ef.Repositories.BaseRepositories
{
    public interface IBaseRepository<TEntity> where TEntity: class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> GetAll(int? page);
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);


        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);
    }
}
