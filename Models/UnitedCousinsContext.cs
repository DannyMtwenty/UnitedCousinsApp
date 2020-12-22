using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnitedCousinsApp.Models;

namespace UnitedCousinsApp.Models
{
    public class UnitedCousinsContext : IdentityDbContext<ApplicationUser>
    {
        public UnitedCousinsContext(DbContextOptions<UnitedCousinsContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Core Identity model and override the defaults if   needed.

            // For example, you can rename the ASP.NET Core Identity table names and   more.

            // Add your customizations after calling base.OnModelCreating(builder);
        }
        public DbSet<Member> Members { get; set; }
        public DbSet<UnitedCousinsApp.Models.Role> Role { get; set; }
    }
}
