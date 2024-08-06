using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using SampleMongodb.Entities;

namespace SampleMongodb.Data
{
    public class MongoDbContext : DbContext
    {
        public MongoDbContext(DbContextOptions<MongoDbContext> options) : base(options)
        {
                
        }

        public DbSet<Category>  Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().ToCollection("Category");

            base.OnModelCreating(modelBuilder);
        }
    }
}
