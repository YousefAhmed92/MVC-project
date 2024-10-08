﻿using Company.Data.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Company.Data.Contexts
{
    public class CompanyDBContext : DbContext
    {
        public CompanyDBContext()
        {
        }

        public CompanyDBContext(DbContextOptions<CompanyDBContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            //modelBuilder.Entity<BaseEntity>().HasQueryFilter(x => !x.IsDeleted);

            base.OnModelCreating(modelBuilder);
        }

        // Define DbSets for your entities
        public DbSet<Employees> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
