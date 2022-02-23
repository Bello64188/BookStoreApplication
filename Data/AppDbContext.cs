using BookStoreApplication.Configurations.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<Genre> Genres { get; set; }  

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //register composite  primary key
            builder.Entity<BookAuthor>().HasKey(b => new { b.AuthorId, b.BookId });
            //register one-many relationship and setting foreign key
            builder.Entity<BookAuthor>().HasOne(a => a.Authors).WithMany(a => a.BookAuthors).HasForeignKey(a => a.AuthorId);
            //register one-many relationship  and setting foreign key
            builder.Entity<BookAuthor>().HasOne(b => b.Books).WithMany(b => b.BookAuthors).HasForeignKey(b=>b.BookId);
            // register one-many relationship  , setting foreign key and Remove Authomatic Delete behavior.
            builder.Entity<Book>().HasOne(c => c.Genre).WithMany(c => c.Books).HasForeignKey(c => c.GenreId).OnDelete(DeleteBehavior.Restrict);

            //register enetities initial seed data
            builder.ApplyConfiguration(new AuthorConfiguartion());
            builder.ApplyConfiguration(new BookConfiguration());
            builder.ApplyConfiguration(new BookAuthorConfiguration());
            builder.ApplyConfiguration(new GenreConfiguration());

        }
    }
}
