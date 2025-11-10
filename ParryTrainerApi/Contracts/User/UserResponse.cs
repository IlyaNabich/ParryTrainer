namespace ParryTrainerApi.Contracts.User;

public record UserResponse(Guid UserId, string UserName, DateTime LastOnlineDate, DateTime RegDate);