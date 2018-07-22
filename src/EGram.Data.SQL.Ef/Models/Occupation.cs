using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.SQL.Ef.Models
{
    public class Occupation
    {
        [Key]
        public int OccupationId { get; set; }
        public string Type { get; set; }
        public string Info { get; set; }

        public Person Person { get; set; }
    }
}
