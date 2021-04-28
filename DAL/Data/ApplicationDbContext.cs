using Microsoft.EntityFrameworkCore;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Data
{
  public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
        public DbSet<user> users { get; set; }
    }
}
