﻿using ecommerce.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ecommerce.Repository;

public class Repository<T> : IRepository<T> where T : class
{
    private AppDbContext _context;
    public Repository(AppDbContext context)
    {
        _context = context;
    }

    public List<T> GetAll()
    {
        return _context.Set<T>().ToList();
    }
    public List<T> GetAll(params Expression<Func<T, object>>[] includes)//GetAll with include(join with another table)
    {
        IQueryable<T> query = _context.Set<T>();
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return query.ToList();
    }
    public List<T> GetAllThenInclude<T1,T2>(Expression<Func<T, T1>> include, Expression<Func<T1,T2>> thenInclude)
    {
        IQueryable<T> query = _context.Set<T>();
        query = query.Include(include).ThenInclude(thenInclude);
        return query.ToList();
    }
    public List<T> Get(params Expression<Func<T, bool>>[] filters)
    {
        IQueryable<T> query = _context.Set<T>();
        foreach (var filter in filters)
        {
            query = query.Where(filter);
        }
        return query.ToList();
    }

    public T? GetById(int id)
    {
        //return _context.Set<T>().ToList().First(r => (int)r.GetType().GetProperty("Id").GetValue(r) == id);
        return _context.Find<T>(id);
    }
    public T? GetById(int id, params Expression<Func<T, object>>[] includes)
    {
        IQueryable<T> query = _context.Set<T>();
        foreach (var include in includes)
        {
            query = query.Include(include);
        }
        return query.ToList().First(r => (int)r.GetType().GetProperty("Id").GetValue(r) == id);
    }
    public void Add(T element)
    {
        _context.Add<T>(element);
        _context.SaveChanges();
    }

    public void Update(T element)
    {
        _context.Update<T>(element);
        _context.SaveChanges();
    }
    public void Delete(T element)
    {
        _context.Remove<T>(element);
        _context.SaveChanges();
    }

}
