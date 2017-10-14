using BookWeb.Api.Models;
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
        public BookDBContext(string BookConnectionString)
        : base("name=BookConnectionString")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
        public DbSet<Book> Books { get; set; }
    }
}