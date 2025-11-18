namespace ParryTrainerApi.Contracts.User;

public record UsersResponse(Guid UserId, string UserName, DateTime LastOnlineDate, DateTime RegDate);