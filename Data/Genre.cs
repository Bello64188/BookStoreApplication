using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Data
{
    public class Genre
    {
        [Key]
        [MaxLength(450)]
        public string Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
