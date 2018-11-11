using System;
using EGram.Data.SQL.Ef.Models;

namespace EGram.Data.SQL.Ef.Seeds
{
    public static class SurveyTypeSeed
    {
        public static SurveyType[] Get()
        {
            return new SurveyType[] {
                new SurveyType
                {
                    SurveyTypeId = 1,
                    Type = "House"
                },
                new SurveyType
                {
                    SurveyTypeId = 2,
                    Type = "Person"
                }
            };
        }
    }
}
