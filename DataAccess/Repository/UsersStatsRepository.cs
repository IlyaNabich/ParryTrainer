using Core.Abstractions;
using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Repository;

public class UsersStatsRepository (ParryTrainerDbContext context): IUsersStatsRepository
{
    private readonly ParryTrainerDbContext _context = context;
    public async Task<UsersStats> Get(Guid userId)
    {
        var usersStatsEntity = await _context.UserStats.FirstOrDefaultAsync(u => u.UserId == userId);
        
        var userStats = UsersStats.CreateStats(usersStatsEntity.UserId);
        
        return userStats;
    }

    public async Task<Guid> Create(Guid userId)
    {
        await _context.AddAsync(userId);
        
        return userId;
    }

    public async Task<Guid> Update(Guid userId, UsersStats usersStats)
    {
        await _context.UserStats.Where(u => u.UserId == userId)
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
        await _context.UserStats.Where(u => u.UserId == userId).ExecuteDeleteAsync();
        
        return userId;
    }
}