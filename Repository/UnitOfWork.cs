using BookStoreApplication.Data;
using BookStoreApplication.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Repository
{
    public class UnitOfWork : IUnitOfWorks
    {
        private readonly AppDbContext _context;


        private IRepository<Book> _books;
        private IRepository<Genre> _genres;
        private IRepository<Author> _authors; 
        private IRepository<BookAuthor> _bookauthors;

        public UnitOfWork(AppDbContext context)
        {
            _context = context;
        }
        public IRepository<Book> Books => _books ??= new Repository<Book>(_context);
        public IRepository<Genre> Genres => _genres ??= new Repository<Genre>(_context);
        public IRepository<Author> Authors => _authors ??= new Repository<Author>(_context);
        public IRepository<BookAuthor> BookAuthors => _bookauthors ??= new Repository<BookAuthor>(_context);

        public void DeleteCurrentBookAuthors(Book book) {
            var currentAuthors = _bookauthors.GetAll(new QueryOption<BookAuthor> { 
            
            Where=b=>b.BookId==book.Id
            });
            foreach (BookAuthor bookAuth in currentAuthors)
            {
                _bookauthors.Delete(bookAuth);// delete from BookAuthors repository
            }
        }
        public void AddNewBookAuthors(Book book, int[] authorIds) {

            foreach (int id in authorIds)
            {
                BookAuthor bookAuthor = new BookAuthor
                {
                    BookId = book.Id,
                    AuthorId = id
                };
                _bookauthors.Insert(bookAuthor);
            }
        
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        //public void Dispose()
        //{
        //    _context.Dispose();
            
        //}
    }
}
