using DataAccess.Entities;
using DataAccess.Entity;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public partial class DbContext (DbContextOptions<DbContext> options)  : Microsoft.EntityFrameworkCore.DbContext(options)
{
    private partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    private partial void OnModelCreatingPartial(ModelBuilder modelBuilder)
    { 
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(AppContext).Assembly);
    }
    
    DbSet<UserEntity> Users { get; set; }
    
    DbSet<UserStatEntity>  UserStats { get; set; }
}