using System.ComponentModel.DataAnnotations;

namespace SUT23_Labb_3___API.Models
{
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(50)]
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public ICollection<PersonInterest> PersonInterest { get; set; }
    }
}
