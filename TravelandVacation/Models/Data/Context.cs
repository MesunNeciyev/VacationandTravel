using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using TravelandVacation.Models.Classes;

namespace TravelandVacation.Models.Data
{
    public class Context: DbContext
    {
        public DbSet<Admin> Admins { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Comments> Comments { get; set; }

        public DbSet<AboutPage> AboutPages { get; set; }

        //public DbSet<HomePage> HomePages { get; set; }

        public DbSet<Contact> Contacts { get; set; }
    }
}