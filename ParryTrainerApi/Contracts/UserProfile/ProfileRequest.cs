namespace ParryTrainerApi.Contracts.UserProfile;

public record ProfileRequest(Guid userId, string userName, string firstName, string lastName, string age, string links, string region, string country, string description);