using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PROG36944_Lab2.Models
{
    public class Author
    {
        [Key]
        public int AuthorID { get; set; }
        [Required]
        [Length(2, 25)]
        [DisplayName("Author's First Name")]
        public string FirstName { get; set; }
        [Required]
        [Length(2,25)]
        [DisplayName("Author's Last Name")]
        public string LastName { get; set; }
        [Required]
        [MinLength(10)]
        [DisplayName("Author's Birth Date")]
        public string BirthDate { get; set; }
        [NotMapped]
        [DisplayName("Author's Full Name")]
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

    }
}
