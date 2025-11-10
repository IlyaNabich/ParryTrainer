
namespace Core.Models;

public class UsersStats
{
    private UsersStats(Guid userId)
    {
        UserId = userId;
        Score = 0;
        BestPlacement = 0;
        ActualPlacement = 0;
        BestMode = "Unknown";
        FavoriteMode = "Unknown";
        AverageTimeReaction = 0;
        BestTimeReaction = 0;
        NumberSuccessParry = 0;
        ParryStreak = 0;
        BestParryStreak = 0;

    }

    public Guid UserId { get; }

    public int Score { get; }

    public int BestPlacement { get; }

    public int ActualPlacement { get; }

    public string BestMode { get; }

    public string FavoriteMode { get; }

    public float AverageTimeReaction { get; }

    public float BestTimeReaction { get; }

    public int NumberSuccessParry { get; }

    public int ParryStreak { get; }

    public int BestParryStreak { get; }

    public static UsersStats CreateStats(Guid userId)
    {
        return new UsersStats(userId);
    }
}