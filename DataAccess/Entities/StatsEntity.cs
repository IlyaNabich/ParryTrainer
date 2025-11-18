namespace DataAccess.Entities;

public class StatsEntity
{
    
    public Guid UserId { get; set; }

    public int Score { get; set; } = 0;

    public int? BestPlacement { get; set; } = 0;

    public int? ActualPlacement { get; set; } = 0;

    public string BestMode { get; set; } = "Unknown";
    
    public string FavoriteMode { get; set; } =  "Unknown";

    public float? AverageTimeReaction { get; set; } = 0;

    public float? BestTimeReaction { get; set; } = 0;

    public int? NumberSuccessParry { get; set; } = 0;

    public int? ParryStreak { get; set; } = 0;

    public int? BestParryStreak { get; set; } = 0;
    
    public UsersEntity UsersEntity { get; set; }
}