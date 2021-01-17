﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entity;
using Core.Entity.Abstract;

namespace Core.DataAccess.Abstract
{
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>>filter=null);
        T Get(Expression<Func<T,bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
