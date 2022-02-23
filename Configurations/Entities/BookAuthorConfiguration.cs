using BookStoreApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Configurations.Entities
{
    public class BookAuthorConfiguration : IEntityTypeConfiguration<BookAuthor>
    {
        public void Configure(EntityTypeBuilder<BookAuthor> builder)
        {
            builder.HasData(
                
                new BookAuthor { AuthorId=1, BookId=2 },
                new BookAuthor { AuthorId=1, BookId=3 },
                new BookAuthor { AuthorId=2, BookId=4 },
                new BookAuthor { AuthorId=3, BookId=5 }
                );
        }
    }
}
