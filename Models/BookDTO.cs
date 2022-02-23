using BookStoreApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class BookDTO:CreateBookDTO
    {
        public int Id { get; set; }        
        public Genre Genre { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }
    }
    public class CreateBookDTO
    {
        [Required(ErrorMessage = "Please Enter Book's Title")]
        [StringLength(100)]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please Enter Book's Price")]
        [Range(0.1, 10000000.0, ErrorMessage = "Price Must greater than 0")]
        public double? Price { get; set; }
        [Required(ErrorMessage = "Please Select Genre")]
        public string GenreId { get; set; }

    }
}
