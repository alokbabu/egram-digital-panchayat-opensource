using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public int EducationLevel { get; set; }
    }
}
