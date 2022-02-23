using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Data
{

    public class Book
    {
        [Key]
        
        public int Id { get; set; }
        [MaxLength(100)]
        public string Title { get; set; }
        public double? Price { get; set; }
       
        [ForeignKey("Genre")]
        [MaxLength(450)]
        public string GenreId { get; set; }
        public Genre Genre { get; set; }

        public ICollection<BookAuthor> BookAuthors { get; set; }



    }
}
