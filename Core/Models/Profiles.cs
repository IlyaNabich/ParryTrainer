namespace Core.Models;

public class Profiles
{
    private Profiles(Guid userId, string firstName, string lastName, string age, string links, string region, string country, string description)
    {
        UserId = userId;
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        Links = links;
        Region = region;
        Country = country;
        Description = description;
    }
    public Guid UserId { get; } 
    
    public string FirstName { get; }
    
    public string LastName { get; }
    
    public string Age { get; }
    
    public string Links { get; }
    
    public string Region { get; }
    
    public string Country { get; }
    
    public string Description {  get; }

    public static Profiles CreateProfile(Guid userId, string firstName, string lastName, 
        string age, string links, string region, string country, string description)
    {
       return new Profiles(userId,  firstName, lastName, age, links, region, country, description);
    }
    
}