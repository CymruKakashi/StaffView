using Microsoft.EntityFrameworkCore;
using StaffView.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StaffView.Data
{
    public class StaffViewContext: DbContext
    {
        public StaffViewContext(DbContextOptions<StaffViewContext> options) : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("Employee");
        }
    }
}
