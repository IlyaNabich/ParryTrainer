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
            .HasOne(x => x.StatsEntity)
            .WithOne(x => x.UsersEntity)
            .HasForeignKey<StatsEntity>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);

        builder
            .HasOne(x => x.ProfilesEntity)
            .WithOne(x => x.UsersEntity)
            .HasForeignKey<ProfilesEntity>(x => x.UserId)
            .OnDelete(DeleteBehavior.Cascade);


    }
}