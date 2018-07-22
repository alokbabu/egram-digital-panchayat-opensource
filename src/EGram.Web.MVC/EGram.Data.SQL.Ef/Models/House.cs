using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.EF.Models
{
    public class House
    {
        [Key]
        public int HouseId { get; set; }
        public string HouseNumber { get; set; }
        public string AddressLine { get; set; }
        public string StreetAddress { get; set; }
        public string PanchayatName { get; set; }
        public string PostOffice { get; set; } //TODO: normalize?
        public Decimal Latitude { get; set; }
        public Decimal Longitude { get; set; }
    }
}
