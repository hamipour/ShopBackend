using Microsoft.EntityFrameworkCore;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Shop.Data.DataContext
{
    public class ShopDbContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer("Data Source=.; Initial Catalog= ShopDb; Integrated Security= true;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<UserRoles> UserRoles { get; set; }

    }
}
