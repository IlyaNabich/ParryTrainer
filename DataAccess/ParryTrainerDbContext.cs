using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public partial class ParryTrainerDbContext(DbContextOptions<ParryTrainerDbContext> options) : DbContext(options)
{
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<UserStatEntity> UserStats { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ParryTrainerDbContext).Assembly);
        
        OnModelCreatingPartial(modelBuilder);
    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}