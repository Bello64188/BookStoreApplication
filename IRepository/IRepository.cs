
using BookStoreApplication.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.IRepository
{
   public interface IRepository<T> where T : class
    {
        
         public IEnumerable<T> GetAll(QueryOption<T> options);
        public T Get(int id);
        public void Insert(T entity);
        public void Update(T entity); 
        public void Delete(T entity);
       
             
    }
}
