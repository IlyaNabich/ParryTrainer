using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess;

public partial class ParryTrainerDbContext : Microsoft.EntityFrameworkCore.DbContext
{
    // Конструктор
    public ParryTrainerDbContext(DbContextOptions<ParryTrainerDbContext> options) 
        : base(options) 
    { 
    }

    // DbSet свойства - должны быть PUBLIC
    public DbSet<UserEntity> Users { get; set; }
    public DbSet<UserStatEntity> UserStats { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder); // Важно: вызвать базовый метод
        
        // Применяем все конфигурации из сборки
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ParryTrainerDbContext).Assembly);
        
        OnModelCreatingPartial(modelBuilder);
    }

    // Partial метод для дополнительной конфигурации
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}