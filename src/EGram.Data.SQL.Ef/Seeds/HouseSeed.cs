using System;
using EGram.Data.SQL.Ef.Models;

namespace EGram.Data.SQL.Ef.Seeds
{
    public static class HouseSeed
    {
        public static House[] Get()
        {
            return new House[]
            {
                new House 
                { 
                    HouseId = 1, 
                    HouseNumber = "B4134",
                    AddressLine = "47 Bharat Bhawan", 
                    StreetAddress = "Kalbadevi Road, Kalbadevi",
                    City = "Mumbai",
                    PostOffice = "Mumbai",
                    PostCode = "987789"
                },
                new House
                {
                    HouseId = 2,
                    HouseNumber = "P-173",
                    AddressLine = "Lake Town",
                    StreetAddress = "Kolkata",
                    City = "Kolata",
                    PostCode = "700089",
                    PostOffice = "Kolkaata"
                },
                new House
                {
                    HouseId = 3,
                    HouseNumber = "Plot No 190 A",
                    AddressLine = "Sec12, Opp.lakme Beauty Center, Vashi, Navi Mumbai",
                    StreetAddress = "Mumbai",
                    City = "Mumbai",
                    PostCode = "400703",
                    PostOffice = "Mumbai"
                }
            };
        }
    }
}
