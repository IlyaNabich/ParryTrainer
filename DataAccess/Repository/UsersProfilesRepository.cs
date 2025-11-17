using Core.Abstractions;
using Core.Models;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class UsersProfilesRepository (ParryTrainerDbContext context): IUsersProfilesRepository
{
    
    
    public async Task<UsersProfiles> GetUserProfileAsync(Guid userId)
    {
        var userProfileEntity = await context.UserProfiles.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == userId);
        
        var userProfile = UsersProfiles.CreateProfile(userProfileEntity.UserId, userProfileEntity.UserName,
            userProfileEntity.FirstName, userProfileEntity.LastName, userProfileEntity.Age, userProfileEntity.Links,
            userProfileEntity.Region,  userProfileEntity.Country, userProfileEntity.Description);
        
        return userProfile;
    }

    public async Task<Guid> CreateUserProfileAsync(UsersProfiles usersProfiles)
    {
        var userProfileEntity = new UsersProfilesEntity
        {
            UserId = usersProfiles.UserId,
            UserName = usersProfiles.UserName,
            FirstName = usersProfiles.FirstName,
            LastName = usersProfiles.LastName,
            Age = usersProfiles.Age,
            Links = usersProfiles.Links,
            Region = usersProfiles.Region,
            Country = usersProfiles.Country,
            Description = usersProfiles.Description
        };
        
        await context.UserProfiles.AddAsync(userProfileEntity);
        await context.SaveChangesAsync();
        
        return usersProfiles.UserId;
    }

    public async Task<UsersProfiles> UpdateUserProfileAsync(UsersProfiles usersProfiles)
    {
        await context.UserProfiles
            .Where(x => x.UserId == usersProfiles.UserId)
            .ExecuteUpdateAsync(x => x
                .SetProperty(a => a.FirstName, usersProfiles.FirstName)
                .SetProperty(b => b.LastName, usersProfiles.LastName)
                .SetProperty(c => c.UserName, usersProfiles.UserName)
                .SetProperty(d => d.Age, usersProfiles.Age)
                .SetProperty(e => e.Links, usersProfiles.Links)
                .SetProperty(f => f.Region, usersProfiles.Region)
                .SetProperty(g => g.Country, usersProfiles.Country)
                .SetProperty(h => h.Description, usersProfiles.Description));
        
        return usersProfiles;
    }
}