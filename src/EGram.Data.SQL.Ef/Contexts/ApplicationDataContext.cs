using System;
using EGram.Data.SQL.Ef.Identity.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EGram.Data.SQL.Ef.Contexts
{
    public class ApplicationDataContext // : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        //public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options)
        //    : base(options)
        //{ }

    }
}
