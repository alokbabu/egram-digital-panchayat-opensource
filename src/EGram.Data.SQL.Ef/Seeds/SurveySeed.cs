using System;
using System.Collections.Generic;
using EGram.Data.SQL.Ef.Models;

namespace EGram.Data.SQL.Ef.Seeds
{
    public static class SurveySeed
    {
        public static Survey[] Get()
        {
            return new Survey[]
            {
                new Survey
                {
                    SurveyId = 1,
                    Name = $"Yearly end survey {DateTime.Today.Year}",
                    Info = "Yearly Survey",
                    CreatedOn = DateTime.Now,
                    ModifiedOn = DateTime.Now,
                    SurveyTypeId = 1,
                    YearId = 1

                }
            };
        }
    }
}
