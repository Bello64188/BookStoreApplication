using BookStoreApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Configurations.Entities
{
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasData( 
            new Book { Id=1,Title="RichDad", GenreId= "financial", Price=60.99 },
            new Book { Id=2,Title="FourQuadrant", GenreId= "financial", Price=90.99 },
            new Book { Id=3,Title="7 Best Habit", GenreId= "education", Price=67.99 },
            new Book { Id=4,Title="Data Processing", GenreId= "education", Price=20.99 },
            new Book { Id=5,Title="Physics", GenreId= "education", Price=61.99 },
            new Book { Id = 6, Title = "1776", GenreId = "history", Price = 100.99 },
            new Book { Id = 7, Title = "1984", GenreId = "scifi", Price = 101.99 },
            new Book { Id = 8, Title = "Tax", GenreId = "financial", Price = 77.99 }

            );
        }
    }
}
