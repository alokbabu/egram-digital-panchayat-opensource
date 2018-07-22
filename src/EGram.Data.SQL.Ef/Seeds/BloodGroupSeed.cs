using System;
using System.Collections.Generic;
using EGram.Data.SQL.Ef.Models;

namespace EGram.Data.SQL.Ef.Seeds
{
    public static class BloodGroupSeed
    {
        public static List<BloodGroup> Get()
        {
            return new List<BloodGroup>
            {
                new BloodGroup { BloodGroupId = 1, Group = "A +"},
                new BloodGroup { BloodGroupId = 2, Group = "A -"},
                new BloodGroup { BloodGroupId = 3, Group = "B +"},
                new BloodGroup { BloodGroupId = 4, Group = "B -"},
                new BloodGroup { BloodGroupId = 5, Group = "O +" },
                new BloodGroup { BloodGroupId = 6, Group = "O -" },
                new BloodGroup { BloodGroupId = 7, Group = "AB +" },
                new BloodGroup { BloodGroupId = 8, Group = "AB -" }
            };
        }
    }
}
