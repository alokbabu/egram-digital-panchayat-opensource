using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.SQL.Ef.Models
{
    public class Education
    {
        [Key]
        public int EducationId { get; set; }
        public string EducationLevel { get; set; }

        public Person Person { get; set; }
    }
}
