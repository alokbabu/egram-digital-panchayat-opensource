using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class Survey
    {
        [Key]
        public int SurveyId { get; set; }
        public int SurveyTypeId { get; set; }//Survey for Person or Survey for House?
        public string Name { get; set; }
        public string Info { get; set; }
        public int YearId { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }

        public SurveyType SurveyType { get; set; }
    }
}
