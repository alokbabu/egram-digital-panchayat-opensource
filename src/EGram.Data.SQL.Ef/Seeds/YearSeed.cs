using System;
using EGram.Data.SQL.Ef.Models;

namespace EGram.Data.SQL.Ef.Seeds
{
    public static class YearSeed
    {
        public static Year[] Get()
        {
            return new Year[]
            {
                new Year{
                    YearId = 1,
                    YearString = "2018"
                },
                new Year{
                    YearId = 2,
                    YearString = "2019"
                }

            };
        }
    }
}
