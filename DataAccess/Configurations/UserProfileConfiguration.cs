using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class UserProfileConfiguration : IEntityTypeConfiguration<UsersProfilesEntity>
{
    public void Configure(EntityTypeBuilder<UsersProfilesEntity> builder)
    {
        builder.HasKey(x => x.UserId);

            builder.HasMany(x => x.CommentsEntity)
                .WithOne(x => x.UsersProfilesEntity)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
    }
}