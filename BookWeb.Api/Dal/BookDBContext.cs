﻿using BookWeb.Api.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;


namespace BookWeb.Api.Dal
{
    public class BookDBContext : DbContext
    {
        public BookDBContext()
        : base("name=BookConnectionString")
        {
        }

        public DbSet<Book> Books { get; set; }
    }
}