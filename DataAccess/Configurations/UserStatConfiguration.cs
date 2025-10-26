using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class UserStatConfiguration : IEntityTypeConfiguration<UserStatEntity>
{
    public void Configure(EntityTypeBuilder<UserStatEntity> builder)
    {
        builder
            .HasKey(x => x.UserId); 
    
        builder
            .HasOne(us => us.UserEntity)
            .WithOne(u => u.UserStat)
            .HasForeignKey<UserStatEntity>(us => us.UserId)
            .IsRequired();
    }
}