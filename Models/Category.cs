using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityProject.Models
{
    public class Category
    {
        public long Id { get; set; }
        public string CategoryCode { get; set; }
        public string Name { get; set; }
        public string Notes { get; set; }
        public long? ParentId { get; set; }
        public Category Parent { get; set; }
        public ICollection<Category> Children { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
