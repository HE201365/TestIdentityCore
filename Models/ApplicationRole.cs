﻿using System;
using Microsoft.AspNetCore.Identity;

namespace IdentityProject.Models
{
    public class ApplicationRole : IdentityRole
    {
        public ApplicationRole() : base(){}

        public ApplicationRole(string roleName) : base(roleName) { }

        public ApplicationRole(string roleName, string description, DateTime creationDate) : base(roleName)
        {
            this.Description = description;
            this.CreationDate = creationDate;
        }

        public string Description { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
