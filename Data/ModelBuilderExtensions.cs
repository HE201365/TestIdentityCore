using System;
using IdentityProject.Models;
using Microsoft.EntityFrameworkCore;

namespace IdentityProject.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category
                {
                    Id = 1,
                    CategoryCode = "c123",
                    Name = "Electronic",
                    Notes = "some notes for Electronics",
                    ParentId = null
                },
                new Category
                {
                    Id = 2,
                    CategoryCode = "c1234",
                    Name = "Tablet",
                    Notes = "some notes for tablets",
                    ParentId = 1
                },
                new Category
                {
                    Id = 3,
                    CategoryCode = "c1235",
                    Name = "PC",
                    Notes = "some notes for PC",
                    ParentId = 1
                }
            );

            modelBuilder.Entity<Item>().HasData(
                new Item
                {
                    Id = 1,
                    Name = "IPad",
                    CategoryId = 2,
                    ApplicationUserId = "e0058870-35d5-4456-a532-754bbcb1b646"
                },
                new Item
                {
                    Id = 2,
                    Name = "MS Surface",
                    CategoryId = 3,
                    ApplicationUserId = "e0058870-35d5-4456-a532-754bbcb1b646"
                },
                new Item
                {
                    Id = 3,
                    Name = "Frigo",
                    CategoryId = 1,
                    ApplicationUserId = "e0058870-35d5-4456-a532-754bbcb1b646"
                }
            );
        }
    }
}
