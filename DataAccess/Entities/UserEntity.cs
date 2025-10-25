using DataAccess.Entities;

namespace DataAccess.Entity;

public class UserEntity
{
    public Guid UserId { get; set; }
    
    public string UserName { get; set; }
    
    public UserStatEntity UserStat { get; set; }
}