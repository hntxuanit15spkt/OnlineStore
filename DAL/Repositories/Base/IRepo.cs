﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL.Data.Entities.Base;


namespace DAL.Repositories.Base
{
    public interface IRepo<T> : IDisposable where T : EntityBase
    {
        int Count { get; }
        bool HasChanges { get; }
        string GetTableName();
        T Find(int? id);
        T Find(Expression<Func<T, bool>> where);
        T Find<TIncludeField>(Expression<Func<T, bool>> where, Expression<Func<T, ICollection<TIncludeField>>> include);
        T Find<TIncludeField>(Expression<Func<T, bool>> where, Expression<Func<T, TIncludeField>> include);

        IEnumerable<T> GetAll();
        IEnumerable<T> GetAll<TIncludeField>(Expression<Func<T, ICollection<TIncludeField>>> include);
        IEnumerable<T> GetAll<TIncludeField>(Expression<Func<T, TIncludeField>> include);
        IEnumerable<T> GetAll<TSortField>(
            Expression<Func<T,TSortField>> orderBy,bool ascending);
        IEnumerable<T> GetAll<TIncludeField, TSortField>(
            Expression<Func<T, ICollection<TIncludeField>>> include, Expression<Func<T, TSortField>> orderBy, bool ascending);
        IEnumerable<T> GetAll<TIncludeField, TSortField>(
            Expression<Func<T, TIncludeField>> include, Expression<Func<T, TSortField>> orderBy, bool ascending);
        IEnumerable<T> GetSome(Expression<Func<T,bool>> where);
        IEnumerable<T> GetSome<TIncludeField>(
            Expression<Func<T,bool>> where, Expression<Func<T, ICollection<TIncludeField>>> include);
        IEnumerable<T> GetSome<TIncludeField>(
            Expression<Func<T,bool>> where, Expression<Func<T, TIncludeField>> include);
        IEnumerable<T> GetSome<TSortField>(
            Expression<Func<T, bool>> where,Expression<Func<T,TSortField>> orderBy, bool ascending);
        IEnumerable<T> GetSome<TIncludeField,TSortField>(
            Expression<Func<T, bool>> where, Expression<Func<T, ICollection<TIncludeField>>> include,
            Expression<Func<T, TSortField>> orderBy, bool ascending = true);
        IEnumerable<T> GetSome<TIncludeField,TSortField>(
            Expression<Func<T, bool>> where, Expression<Func<T, TIncludeField>> include,
            Expression<Func<T, TSortField>> orderBy, bool ascending = true);
        IEnumerable<T> GetRange(int skip, int take);
        IEnumerable<T> GetRange(IQueryable<T> query,int skip, int take);
        int Add(T entity, bool persist = true);
        int AddRange(IEnumerable<T> entities, bool persist = true);
        int Update(T entity, bool persist = true);
        int UpdateRange(IEnumerable<T> entities, bool persist = true);
        int Delete(T entity, bool persist = true);
        int DeleteRange(IEnumerable<T> entities, bool persist = true);
        int Delete(int id, byte[] timeStamp, bool persist = true);
        int SaveChanges();
    }
}
