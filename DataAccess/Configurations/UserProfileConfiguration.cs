using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class UserProfileConfiguration : IEntityTypeConfiguration<ProfilesEntity>
{
    public void Configure(EntityTypeBuilder<ProfilesEntity> builder)
    {
        builder.HasKey(x => x.UserId);

            builder.HasMany(x => x.CommentsEntity)
                .WithOne(x => x.ProfilesEntity)
                .HasForeignKey(x => x.UserId)
                .OnDelete(DeleteBehavior.Cascade);
    }
}