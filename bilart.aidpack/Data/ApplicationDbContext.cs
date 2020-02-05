using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace bilart.aidpack.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<FirstAidKitItem> FirstAidKitItems { get; set; }
        public DbSet<FirstAidKit> FirstAidKits { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}
