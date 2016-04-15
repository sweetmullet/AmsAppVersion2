using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace AmsApp.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        // public DateTime CreationDate { get; set; }
        public int RoleId { get; set; }
        //public decimal Price { get; set; }
    }

    public class AmsAppDBContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<UserViews> UserViews { get; set; }
        public DbSet<Views> Views { get; set; }

        public AmsAppDBContext()
            : base("AmsAppConn")
        {
        }
    }
}