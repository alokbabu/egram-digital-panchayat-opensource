using System;
using EGram.Data.SQL.Ef.Models;

namespace EGram.Data.SQL.Ef.Seeds
{
    public static class EducationSeed
    {
        public static Education[] Get()
        {
            return new Education[]
            {
                new Education { EducationId = 1, EducationLevel = "Basic School" },
                new Education { EducationId = 2, EducationLevel = "High School" },
                new Education { EducationId = 3, EducationLevel = "Predegree/Diploma" },
                new Education { EducationId = 4, EducationLevel = "Graduate" },
                new Education { EducationId = 5, EducationLevel = "Post Graduate" },
                new Education { EducationId = 6, EducationLevel = "Doctorate or Higher" }
            };
        }
    }
}
