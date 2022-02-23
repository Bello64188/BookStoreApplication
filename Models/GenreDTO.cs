using BookStoreApplication.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class GenreDTO
    {
        [Required(ErrorMessage ="Enter Genre Id")]
        [StringLength(50)]
       
        public string Id { get; set; }
        [Required(ErrorMessage ="Enter Genre Name")]
        [StringLength(50)]
        public string Name { get; set; }
        public ICollection<Book> Books { get; set; }

    }
}
