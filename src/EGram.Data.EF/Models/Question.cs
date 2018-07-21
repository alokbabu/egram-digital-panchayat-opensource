using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class Question
    {
        [Key]
        public int QuestionId { get; set; }
        public string SurveyId { get; set; }
        public int QuestionTypeId { get; set; }
        public string SurveyQuestion { get; set; }

        public QuestionType QuestionType { get; set; }
    }
}
