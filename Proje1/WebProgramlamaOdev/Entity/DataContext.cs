﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Identity.EntityFramework;
using WebProgramlamaOdev.Identity;

namespace WebProgramlamaOdev.Entity
{
    public class DataContext:DbContext
    {

        public DataContext():base("dataConnection")
        {
            Database.SetInitializer(new DataInitializer());
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}