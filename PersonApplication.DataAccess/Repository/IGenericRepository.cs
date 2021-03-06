﻿using PersonApplication.DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace PersonApplication.DataAccess.Repository
{
    public interface IGenericRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();

        T GetById(object Id);
        IEnumerable<T> FindBy(Expression<Func<T, bool>> predicate);
        T Add(T entity);
    
        void Delete(T entity);

        void Delete(Object Id);
        void Edit(T entity);
        void Save();
    }
}
