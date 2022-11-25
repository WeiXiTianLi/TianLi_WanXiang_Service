using Microsoft.EntityFrameworkCore;
using TianLi_WanXiang_Service.Models;

namespace TianLi_WanXiang_Service.Data
{
    public class ObjectContext :DbContext
    {
        public ObjectContext(DbContextOptions<ObjectContext> options) : base(options)
        {
        }

        public DbSet<Models.Object> Objects { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Models.Object>().ToTable("Object");
        }
    }
}
