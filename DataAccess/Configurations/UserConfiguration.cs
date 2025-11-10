using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class UserConfiguration: IEntityTypeConfiguration<UsersEntity>
{
    public void Configure(EntityTypeBuilder<UsersEntity> builder)
    {
        builder
            .HasKey(x => x.UserId);

        builder
            .HasOne(x => x.UsersStatsEntity)
            .WithOne(x => x.UsersEntity)
            .HasForeignKey<UsersStatsEntity>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.UsersProfilesEntity)
            .WithOne(x => x.UsersEntity)
            .HasForeignKey<UsersProfilesEntity>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);


    }
}