using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class UserStatConfiguration : IEntityTypeConfiguration<UserStatEntity>
{
    public void Configure(EntityTypeBuilder<UserStatEntity> builder)
    {
        builder
            .HasIndex(x => x.UserId)
            .IsUnique();
    }
}