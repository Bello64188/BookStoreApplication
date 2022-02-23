using BookStoreApplication.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class BookAuthorDTO
    {
        public int BookId { get; set; }
        public int AuthorId { get; set; }

        public Book Books { get; set; }
        public Author Authors { get; set; }

    }
}
