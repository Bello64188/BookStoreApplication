using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Data
{
    public class BookAuthor
    {
       
        public int BookId { get; set; }
        public int AuthorId { get; set; }
        [ForeignKey("BookId")]
        public Book Books { get; set; }
        [ForeignKey("AuthorId")]
        public Author Authors { get; set; }

    }
}
