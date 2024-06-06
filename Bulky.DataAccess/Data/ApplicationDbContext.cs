using Bulky.Models;
using Microsoft.EntityFrameworkCore;

namespace Bulky.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
        
    }
    public DbSet<Category> Categories { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Seed the Category table with example data
        modelBuilder.Entity<Category>().HasData(
            new Category { CategoryId = 1, Name = "Books", DisplayOrder = 1},
            new Category { CategoryId = 2, Name = "Electronics", DisplayOrder = 2},
            new Category { CategoryId = 3, Name = "Clothing", DisplayOrder = 3}
        );
    }

}