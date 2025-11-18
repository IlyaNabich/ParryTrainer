using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public partial class ParryTrainerDbContext(DbContextOptions<ParryTrainerDbContext> options) : DbContext(options)
{
    public DbSet<UsersEntity> Users { get; set; }
    public DbSet<StatsEntity> Stats { get; set; }
    public DbSet<ProfilesEntity> Profiles { get; set; }
    public DbSet<CommentsEntity> Comments { get; set; }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ParryTrainerDbContext).Assembly);
        
        OnModelCreatingPartial(modelBuilder);
    }
    
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}