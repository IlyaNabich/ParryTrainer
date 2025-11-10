using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class UserStatConfiguration : IEntityTypeConfiguration<UsersStatsEntity>
{
    public void Configure(EntityTypeBuilder<UsersStatsEntity> builder)
    {
        builder
            .HasKey(e => e.UserId);
        
    }
}