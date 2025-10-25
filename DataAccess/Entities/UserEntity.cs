namespace DataAccess.Entities;

public class UserEntity
{
    public Guid UserId { get; set; }
    
    public string UserName { get; set; }
    
    public string Login { get; set; }
    
    public string Password { get; set; }
    
    public UserStatEntity UserStat { get; set; }
}