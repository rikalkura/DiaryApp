using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<DiaryEntity> DiaryEntities { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<DiaryEntity>().HasData(
            new DiaryEntity 
            { 
                Id = 1, Title = "Completed .Net course",
                Description = "Completed just now",
                CreatedAt = new DateTime(2024, 05, 30)
            },
            new DiaryEntity
            {
                Id = 2,
                Title = "Played Archero",
                Description = "Played archero for 5 minutes",
                CreatedAt = new DateTime(2024, 05, 30)
            },
            new DiaryEntity
            {
                Id = 3,
                Title = "Watched youtube",
                Description = "Watched youtube for 10 minutes",
                CreatedAt = new DateTime(2024, 05, 30)
            }
            );
    }
}
