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
            builder.Entity<user>()
             .HasData(
             new user { user_id = 1, user_username = "nttung", user_password = "nttung", user_firstname = "Tung", user_lastname = "Nguyen", user_gender = 1, user_email = "nttung@gmai.com", user_birthday = DateTime.Now, user_phone = "096431808", user_created_by = 1, user_isdeleted = 0, user_status = 1},
             new user { user_id = 2, user_username = "abc", user_password = "abc", user_firstname = "abc", user_lastname = "abc", user_gender = 1, user_email = "abc@gmai.com", user_birthday = DateTime.Now, user_phone = "096431808", user_created_by = 1, user_isdeleted = 0, user_status = 1 },
             new user { user_id = 3, user_username = "xyz", user_password = "xyz", user_firstname = "xyz", user_lastname = "xyz", user_gender = 1, user_email = "xyz@gmai.com", user_birthday = DateTime.Now, user_phone = "096431808", user_created_by = 1, user_isdeleted = 0, user_status = 1 }
             );
            base.OnModelCreating(builder);
        }
        public DbSet<user> users { get; set; }
    }
}
