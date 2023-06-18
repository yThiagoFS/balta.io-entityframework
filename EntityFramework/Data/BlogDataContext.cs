using Microsoft.EntityFrameworkCore;
using EntityFramework.Models;

namespace EntityFramework.Data 
{
    public class BlogDataContext : DbContext 
    {
        private const string CONNECTION = "Data Source=DESKTOP-DIFT32I\\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True; TrustServerCertificate=True" ;

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        // public DbSet<PostTag> PostTags { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        // public DbSet<UserRole> UserRoles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opts) => opts.UseSqlServer(CONNECTION);
    }
}