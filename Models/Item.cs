using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IdentityProject.Models
{
    public class Item
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long CategoryId { get; set; }
        public Category Category { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
