using Microsoft.EntityFrameworkCore;

namespace MVC_CRUD_EF_TwoTables.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Models.Property> Properties { get; set; }
        public DbSet<Models.Tenant> Tenants { get; set; }

        // Configure the relationship between Property and Tenant
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure one-to-many relationship between Property and Tenant
            modelBuilder.Entity<Models.Property>()
                .HasMany(p => p.Tenants)
                .WithOne(t => t.Property)
                .HasForeignKey("PropertyID") // Assuming Tenant has a foreign key PropertyId
                .OnDelete(DeleteBehavior.Cascade); // Optional: specify delete behavior
        }
    }
}
