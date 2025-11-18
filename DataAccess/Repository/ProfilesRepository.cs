using Core.Abstractions;
using Core.Models;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class ProfilesRepository (ParryTrainerDbContext context): IProfilesRepository
{
    
    
    public async Task<Profiles> GetUserProfileAsync(Guid userId)
    {
        var userProfileEntity = await context.Profiles.AsNoTracking().FirstOrDefaultAsync(x => x.UserId == userId);
        
        var userProfile = Profiles.CreateProfile(userProfileEntity.UserId, userProfileEntity.UserName,
            userProfileEntity.FirstName, userProfileEntity.LastName, userProfileEntity.Age, userProfileEntity.Links,
            userProfileEntity.Region,  userProfileEntity.Country, userProfileEntity.Description);
        
        return userProfile;
    }

    public async Task<Guid> CreateUserProfileAsync(Profiles profiles)
    {
        var userProfileEntity = new ProfilesEntity
        {
            UserId = profiles.UserId,
            UserName = profiles.UserName,
            FirstName = profiles.FirstName,
            LastName = profiles.LastName,
            Age = profiles.Age,
            Links = profiles.Links,
            Region = profiles.Region,
            Country = profiles.Country,
            Description = profiles.Description
        };
        
        await context.Profiles.AddAsync(userProfileEntity);
        await context.SaveChangesAsync();
        
        return profiles.UserId;
    }

    public async Task<Profiles> UpdateUserProfileAsync(Profiles profiles)
    {
        await context.Profiles
            .Where(x => x.UserId == profiles.UserId)
            .ExecuteUpdateAsync(x => x
                .SetProperty(a => a.FirstName, profiles.FirstName)
                .SetProperty(b => b.LastName, profiles.LastName)
                .SetProperty(c => c.UserName, profiles.UserName)
                .SetProperty(d => d.Age, profiles.Age)
                .SetProperty(e => e.Links, profiles.Links)
                .SetProperty(f => f.Region, profiles.Region)
                .SetProperty(g => g.Country, profiles.Country)
                .SetProperty(h => h.Description, profiles.Description));
        
        return profiles;
    }
}