
using BookStoreApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Configurations.Entities
{
    public class AuthorConfiguartion : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasData(

                new Author {Id=1, FirstName="Bello", LastName="Abdulazeez" },
                new Author {Id=2, FirstName="Kola", LastName="Dapo" },
                new Author {Id=3, FirstName="Sherif", LastName="Habeeb" },
                new Author {Id=4, FirstName="Jamiu", LastName="Zarumi" },
                new Author {Id=5, FirstName="Alaba", LastName="Abiodun" },
                new Author {Id=6, FirstName="Omotosho", LastName="Bukola" }


                );
        }
    }
}
