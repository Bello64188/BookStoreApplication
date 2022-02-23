using BookStoreApplication.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookStoreApplication.Models
{
    public class AuthorDTO:CreateAuthorDTO
    {
        public int Id { get; set; }        

        public ICollection<BookAuthor> BookAuthors { get; set; }
    }

    public class CreateAuthorDTO
    {
        [Required(ErrorMessage ="Enter Your FirstName")]
        [StringLength(100)]
        
        public string FirstName { get; set; }
        [Required(ErrorMessage ="Enter Your LastName")]
        [StringLength(100)]
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";

    }
}
