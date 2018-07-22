using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.SQL.Ef.Models
{
    public class BloodGroup
    {
        public int BloodGroupId { get; set; }
        public string Group { get; set; }

        public Person Person { get; set; }
    }
}
