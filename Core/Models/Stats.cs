
namespace Core.Models;

public class Stats
{
    private Stats(Guid userId)
    {
        UserId = userId;
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

    public static Stats CreateStats(Guid userId)
    {
        return new Stats(userId);
    }
}