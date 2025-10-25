namespace DataAccess.Entities;

public class UserStatEntity
{
    public Guid UserStatId { get; set; }
    
    public Guid UserId { get; set; }
    
    public int Score { get; set; }
    
    public int WorldPlace { get; set; }
    
    public decimal AverageReactTime { get; set; }
    
    public int NumberSuccessParry { get; set; }
    
    public UserEntity UserEntity { get; set; }
}