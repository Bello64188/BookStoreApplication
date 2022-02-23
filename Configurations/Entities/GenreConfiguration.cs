using BookStoreApplication.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Configurations.Entities
{
    public class GenreConfiguration : IEntityTypeConfiguration<Genre>
    {
        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.HasData(
                new Genre {Id="financial", Name="Financial" },
                new Genre {Id="education", Name="Education" },
                new Genre {Id="scifi", Name="Science Fiction" },
                new Genre {Id="history", Name="History" },
                new Genre { Id = "novel", Name = "Novel" }



                );
        }
    }
}
