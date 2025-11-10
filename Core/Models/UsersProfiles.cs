namespace Core.Models;

public class UsersProfiles
{
    private UsersProfiles(Guid userId, string userName, string firstName, string lastName, string age, string links, string region, string country, string description)
    {
        UserId = userId;
        UserName = userName;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Links = links;
        Region = region;
        Country = country;
        Description = description;
    }
    public Guid UserId { get; } 
    
    public string UserName { get; }
    
    public string FirstName { get; }
    
    public string LastName { get; }
    
    public string Age { get; }
    
    public string Links { get; }
    
    public string Region { get; }
    
    public string Country { get; }
    
    public string Description {  get; }

    public static UsersProfiles CreateProfile(Guid userId, string userName, string firstName, string lastName, 
        string age, string links, string region, string country, string description)
    {
       return new UsersProfiles(userId, userName,  firstName, lastName, age, links, region, country, description);
    }
    
}