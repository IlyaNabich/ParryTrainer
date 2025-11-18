namespace ParryTrainerApi.Contracts.UserProfile;

public record UsersProfileResponse(Guid userId,string userName, string firstName, string lastName, string age, string links, string region, string country, string description);

    
