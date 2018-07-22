using System;
using EGram.Data.SQL.Ef.Models;

namespace EGram.Data.SQL.Ef.Seeds
{
    public static class OccupationSeed
    {
        public static Occupation[] Get()
        {
            return new Occupation[]
            {
                new Occupation
                {
                    OccupationId = 1,
                    Type = "Teacher",
                    Info = "Primary School Teacher"
                },
                new Occupation
                {
                    OccupationId = 2,
                    Type = "Daily wage",
                    Info = "Carpenter"

                },
                new Occupation
                {
                    OccupationId = 3,
                    Type = "Driver",
                    Info = "Bus Driver, Truck Driver"

                },
                new Occupation
                {
                    OccupationId = 4,
                    Type = "Small scale Business",
                    Info = "Business with less than 10 employes"

                },
                new Occupation
                {
                    OccupationId = 5,
                    Type = "Medium scale Busiess",
                    Info = "Business with 10-100 employees"
                },
                new Occupation
                {
                    OccupationId = 6,
                    Type = "Large Scale Business",
                    Info = "Business with morethan 100 employees"
                },
                new Occupation
                {
                    OccupationId = 7,
                    Type = "Engineer",
                    Info = "Electical, Civil, Software, Mechanical"
                        
                },
                new Occupation
                {
                    OccupationId = 8,
                    Type = "Doctor",
                    Info = "Medical Doctors, Vetinary Doctors etc"
                }
            };
        }
    }
}
