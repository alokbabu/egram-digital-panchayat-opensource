using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class BloodGroup
    {
        [Key]
        public int BloodGroupId { get; set; }
        public string Group { get; set; }
    }
}
