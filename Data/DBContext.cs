using Microsoft.EntityFrameworkCore;
using Patric_God.Models;

namespace Patric_God.Data
{
    public class DBContext : DbContext
    {
        public DBContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<User>  NewUser { get; set; }

        public DbSet<Blog> Blogs { get; set; }

        public DbSet<Post> Posts { get; set; }

    }
}
