using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configurations;

public class UserConfiguration: IEntityTypeConfiguration<UserEntity>
{
    public void Configure(EntityTypeBuilder<UserEntity> builder)
    {
        builder
            .HasKey(x => x.UserId); // Указываем первичный ключ
        
        builder
            .HasOne(x => x.UserStat)
            .WithOne(x => x.UserEntity)
            .HasForeignKey<UserStatEntity>(x => x.UserId);
    }
}