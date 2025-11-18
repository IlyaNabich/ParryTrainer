using Core.Abstractions;
using Core.Models;
using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class StatsRepository (ParryTrainerDbContext context): IStatsRepository
{
    public async Task<Stats> Get(Guid userId)
    {
        var usersStatsEntity = await context.Stats.FirstOrDefaultAsync(u => u.UserId == userId);
        
        var userStats = Stats.CreateStats(usersStatsEntity.UserId);
        
        return userStats;
    }

    public async Task<Guid> Create(Stats stats)
    {
        var userStatsEntity = new StatsEntity()
        {
            UserId = stats.UserId,
        };
        await context.Stats.AddAsync(userStatsEntity);
        await context.SaveChangesAsync();
        
        return stats.UserId;
    }

    public async Task<Guid> Update(Guid userId, Stats stats)
    {
        await context.Stats.Where(u => u.UserId == userId)
            .ExecuteUpdateAsync(a => a
                .SetProperty(m => m.Score, stats.Score)
                .SetProperty(l => l.BestPlacement, stats.BestPlacement)
                .SetProperty(x => x.ActualPlacement, stats.ActualPlacement)
                .SetProperty(c => c.BestMode, stats.BestMode)
                .SetProperty(n => n.FavoriteMode, stats.FavoriteMode)
                .SetProperty(b => b.AverageTimeReaction, stats.AverageTimeReaction)
                .SetProperty(z => z.BestTimeReaction, stats.BestTimeReaction)
                .SetProperty(h => h.NumberSuccessParry, stats.NumberSuccessParry)
                .SetProperty(q => q.ParryStreak, stats.ParryStreak)
                .SetProperty(y => y.BestParryStreak, stats.BestParryStreak));

        return userId;
    }

    public async Task <Guid> Clear(Guid userId)
    {
        await context.Stats.Where(u => u.UserId == userId).ExecuteDeleteAsync();
        
        return userId;
    }
}