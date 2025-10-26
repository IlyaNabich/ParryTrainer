using DataAccess.Entities;

namespace Core.Models;

public class UserStat
{
    public Guid UserId { get; set; }

    public int Score { get; set; } = 0;

    public int? WorldPlace { get; set; } = null;

    public float? AverageReactTime { get; set; } = null;

    public int? NumberSuccessParry { get; set; } = null;
    
    public int? ParryStreak { get; set; } = null;

    public int? BestParryStreak { get; set; } = null;
    
    public UserEntity UserEntity { get; set; }
}