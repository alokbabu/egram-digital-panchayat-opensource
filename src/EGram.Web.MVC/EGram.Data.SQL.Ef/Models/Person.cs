using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public int Firstname { get; set; }
        public int Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public int EducationId { get; set; }
        public int OccupationId { get; set; }
        public string MobileNumber { get; set; }
        public string Email { get; set; }
        public bool RecieveNotification { get; set; }
        public int BloodGroupId { get; set; }

        public Education Education { get; set; }
        public BloodGroup BloodGroup { get; set; }
        
    }
}
