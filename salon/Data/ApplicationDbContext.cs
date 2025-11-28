using Microsoft.EntityFrameworkCore;
using Salon.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Salon.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Staff> Staffs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed two sample staff records
            modelBuilder.Entity<Staff>().HasData(
                new Staff { Id = 1, StaffId = "staff1", Password = "password1" },
                new Staff { Id = 2, StaffId = "staff2", Password = "password2" }
            );
        }
    }
}
