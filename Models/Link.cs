using System.ComponentModel.DataAnnotations;

namespace SUT23_Labb_3___API.Models
{
    public class Link
    {
        [Key]
        public int LinkID { get; set; }
        public string Url { get; set; }

        public int PersonInterestID { get; set; }
        public PersonInterest PersonInterest { get; set; }
    }
}
