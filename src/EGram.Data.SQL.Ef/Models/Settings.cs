using System;
using System.ComponentModel.DataAnnotations;

namespace EGram.Data.SQL.Ef.Models
{
    public class Settings
    {
        [Key]
        public int SettingsId { get; set; }
        public string PanchayatName { get; set; }
    }
}
