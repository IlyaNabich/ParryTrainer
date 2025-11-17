using Core.Abstractions;
using Core.Models;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class UsersStatsRepository (ParryTrainerDbContext context): IUsersStatsRepository
{
    public async Task<UsersStats> Get(Guid userId)
    {
        var usersStatsEntity = await context.UserStats.FirstOrDefaultAsync(u => u.UserId == userId);
        
        var userStats = UsersStats.CreateStats(usersStatsEntity.UserId);
        
        return userStats;
    }

    public async Task<Guid> Create(UsersStats userStats)
    {
        var userStatsEntity = new UsersStatsEntity()
        {
            UserId = userStats.UserId,
        };
        await context.UserStats.AddAsync(userStatsEntity);
        await context.SaveChangesAsync();
        
        return userStats.UserId;
    }

    public async Task<Guid> Update(Guid userId, UsersStats usersStats)
    {
        await context.UserStats.Where(u => u.UserId == userId)
            .ExecuteUpdateAsync(a => a
                .SetProperty(m => m.Score, usersStats.Score)
                .SetProperty(l => l.BestPlacement, usersStats.BestPlacement)
                .SetProperty(x => x.ActualPlacement, usersStats.ActualPlacement)
                .SetProperty(c => c.BestMode, usersStats.BestMode)
                .SetProperty(n => n.FavoriteMode, usersStats.FavoriteMode)
                .SetProperty(b => b.AverageTimeReaction, usersStats.AverageTimeReaction)
                .SetProperty(z => z.BestTimeReaction, usersStats.BestTimeReaction)
                .SetProperty(h => h.NumberSuccessParry, usersStats.NumberSuccessParry)
                .SetProperty(q => q.ParryStreak, usersStats.ParryStreak)
                .SetProperty(y => y.BestParryStreak, usersStats.BestParryStreak));

        return userId;
    }

    public async Task <Guid> Clear(Guid userId)
    {
        await context.UserStats.Where(u => u.UserId == userId).ExecuteDeleteAsync();
        
        return userId;
    }
}