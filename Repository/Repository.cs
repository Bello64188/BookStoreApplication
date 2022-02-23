using BookStoreApplication.Data;
using BookStoreApplication.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _context;
        private DbSet<T> _dbset;
        public Repository(AppDbContext context)
        {
            _context = context;
            _dbset = context.Set<T>();
        }
        public void Delete(T entity)
        {
            _dbset.Remove(entity);
        }

        public T Get(int id)
        {
          return  _dbset.Find(id);
        }

        public IEnumerable<T> GetAll(QueryOption<T> options)
        {
            IQueryable<T> query = _dbset;
            foreach (string includes in options.GetIncludes())
            {
              query=  query.Include(includes);
            }
            if (options.HasOrder)
            {
              query=  query.OrderBy(options.OrderBy);
            }
            if (options.HasWhere)
            {
             query=   query.Where(options.Where);
            }
            if (options.HasPaging)
            {
                query = query.PageBy(options.PageNumber, options.PageSize);
            }
            return query.ToList();

        }

        public void Insert(T entity)
        {
            _dbset.Add(entity);
        }

      

        public void Update(T entity)
        {
            _dbset.Update(entity);
        }
    }
}
