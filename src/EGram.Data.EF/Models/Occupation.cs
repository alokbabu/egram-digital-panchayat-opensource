using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class Occupation
    {
        [Key]
        public int OccupationId { get; set; }
        public string Type { get; set; }
    }
}
