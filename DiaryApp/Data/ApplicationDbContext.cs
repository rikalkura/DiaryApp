using DiaryApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DiaryApp.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    public DbSet<DiaryEntity> DiaryEntities { get; set; }
}
