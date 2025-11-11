
namespace Core.Models;

public class UsersStats
{
    private UsersStats(Guid userId)
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

    public static UsersStats CreateStats(Guid userId)
    {
        return new UsersStats(userId);
    }
}