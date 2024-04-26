﻿using System.ComponentModel.DataAnnotations;

namespace SUT23_Labb_3___API.Models
{
    public class Interest
    {
        [Key]
        public int InterestID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        public ICollection<PersonInterest> PersonInterests { get; set; }
    }
}
