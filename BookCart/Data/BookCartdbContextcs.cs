using BookCart.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BookCart.Data
{
    public class BookCartDbContext : DbContext
    {
        public BookCartDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }
}