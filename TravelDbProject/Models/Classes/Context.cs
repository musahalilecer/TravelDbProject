﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TravelDbProject.Models.Classes
{
    public class Context : DbContext
    {
        public DbSet<AboutUs> AboutUss { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Adres> Adress { get; set; }
        public DbSet<AnaSayfa> AnaSayfas { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Commentss { get; set; }
        public DbSet<Contact> Contacts { get; set; }
    }
}