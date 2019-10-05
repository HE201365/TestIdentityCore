using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser() : base(){}

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Country { get; set; }
        public string City { get; set; }
        public ICollection<Item> Items { get; set; }
    }
}
