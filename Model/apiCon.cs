using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Model;
namespace Model
{
    
    public class apiCon:DbContext
    {
        public DbSet<user> Users { get; set; }
        public DbSet<role> Roles { get; set; }
        public DbSet<userroles> Userroles { get; set; }
        public apiCon(DbContextOptions options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<user>().HasData(
            new user { ID = 1, Username = "mohammed", Password = "123" });
            modelBuilder.Entity<role>().HasData(
            new role { RoleID = 1, name = "Admin" });
            modelBuilder.Entity<userroles>().HasData(
            new userroles { ID = 1, userID = 1, roleID = 1 });
        }
    }
}
