using Microsoft.EntityFrameworkCore;
using EfMapping.Models;
using EfMapping.Data.Mappings;

namespace EfMapping.Data 
{
    public class BlogDataContext : DbContext
    {
        private const string CONNECTION = "Data Source=DESKTOP-DIFT32I\\SQLEXPRESS;Initial Catalog=Blog;Integrated Security=True; TrustServerCertificate=True";

        public DbSet<Category> Categories { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder opts) => opts.UseSqlServer(CONNECTION);

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CategoryMap());

            builder.ApplyConfiguration(new PostMap());

            builder.ApplyConfiguration(new UserMap());
        }
    }

}