using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheReddit.Entities;

namespace TheReddit.Database
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder builder)
        {

        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<User> Users { get; set; }

    }
}
