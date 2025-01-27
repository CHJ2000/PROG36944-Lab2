using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROG36944_Lab2.Models
{
    public class Review
    {
        [Key] // primary key for Review table
        public int ReviewID { get; set; }
        [ForeignKey("Book")] //foreign key referencing Book table
        public int BookID { get; set; }
        [Required]
        [Length(2,50)]
        [DisplayName("Reviewer Name")]
        public string ReviewerName { get; set; }
        [Required]
        [Range(1,5)]
        public int Rating { get; set; }
        [Length(0,255)]
        public string Comment { get; set; }
        [ValidateNever]
        public Book Book { get; set; }
    }
}
