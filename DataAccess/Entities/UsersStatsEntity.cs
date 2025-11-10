namespace DataAccess.Entities;

public class UsersStatsEntity
{
    
    public Guid UserId { get; set; }

    public int Score { get; set; }

    public int? BestPlacement { get; set; }
    
    public int? ActualPlacement { get; set; }
    
    public string BestMode { get; set; }
    
    public string FavoriteMode { get; set; }

    public float? AverageTimeReaction {get; set; }
    
    public float? BestTimeReaction {get; set; }

    public int? NumberSuccessParry { get; set; }
    
    public int? ParryStreak { get; set; }

    public int? BestParryStreak { get; set; }
    
    public UsersEntity UsersEntity { get; set; }
}