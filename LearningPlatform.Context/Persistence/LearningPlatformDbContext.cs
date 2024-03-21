using LearningPlatform.Context.Entities;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.Context.Persistence;

public class LearningPlatformDbContext :DbContext
{
    public LearningPlatformDbContext(DbContextOptions<LearningPlatformDbContext> options) : base(options)
    {
    }
    // TODO: Add DbSet for each entityß
    // public DbSet<Course> Courses { get; set; } = null!;
    public DbSet<Test> Tests { get; set; } = null!;
}