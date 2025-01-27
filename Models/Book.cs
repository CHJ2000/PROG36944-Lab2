using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROG36944_Lab2.Models
{
    public class Book
    {
        [Key] // primary key for Book table 
        public int BookID { get; set; }
        [Required]
        [Length(2,255)]
        [DisplayName("Book Title")]
        public string Title { get; set; }
        [Required]
        [Range(0, 2025)]
        [DisplayName("Book Publishing Year")]
        public int PublishedYear { get; set; }
        [Required]
        [Length(4,20)]
        [DisplayName("Book Genre")]
        public string Genre { get; set; }
        [ForeignKey("Author")] // foreign key referencing Author table
        public int AuthorID { get; set; }
        [ValidateNever]
        public Author Author { get; set; }
    }
}
