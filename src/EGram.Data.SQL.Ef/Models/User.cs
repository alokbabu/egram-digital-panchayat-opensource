using System;
namespace EGram.Data.SQL.Ef.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public byte[] Salt { get; set; }

    }
}
