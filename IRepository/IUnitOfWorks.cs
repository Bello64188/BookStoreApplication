using BookStoreApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.IRepository
{
    interface IUnitOfWorks
    {
        public IRepository<Book> Books { get; }
        public IRepository<Genre> Genres { get; }        
        public IRepository<BookAuthor> BookAuthors { get; } 
        public IRepository<Author> Authors { get; }  
        public void SaveChanges();

    }
}
