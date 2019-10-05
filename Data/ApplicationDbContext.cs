using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using IdentityProject.Models;


namespace IdentityProject.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Category>().HasData(
            //    new Category
            //    {
            //        Id = (long)1,
            //        CategoryCode = "c123",
            //        Name = "Electronic",
            //        Notes = "some notes for Electronics",
            //        ParentId = null
            //    },
            //    new Category
            //    {
            //        Id = (long)2,
            //        CategoryCode = "c1234",
            //        Name = "Tablet",
            //        Notes = "some notes for tablets",
            //        ParentId = 1
            //    },
            //    new Category
            //    {
            //        Id = (long)3,
            //        CategoryCode = "c1235",
            //        Name = "PC",
            //        Notes = "some notes for PC",
            //        ParentId = 1
            //    }
            //);
            modelBuilder.Seed();
        }
    }
}
