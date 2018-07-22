using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class SurveyType
    {
        [Key]
        public int SurveyTypeId { get; set; }
        public string Type { get; set; } //TODO: Member, House
    }
}
