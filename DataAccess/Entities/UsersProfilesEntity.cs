namespace DataAccess.Entities;

public class UsersProfilesEntity
{
    public Guid UserId { get; set; }
    
    public string UserName { get; set; }
    
    public string FirstName { get; set; }
    
    public string LastName { get; set; }
    
    public string Age { get; set; }
    
    public string Links { get; set; }
    
    public string Region { get; set; }
    
    public string Country { get; set; }
    
    public string Description {  get; set; }
    
    public UsersEntity UsersEntity { get; set; }
    
    public List<CommentsEntity> CommentsEntity { get; set; }
}