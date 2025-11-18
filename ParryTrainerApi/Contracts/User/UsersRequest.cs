namespace ParryTrainerApi.Contracts.User;

public record UsersRequest(
    string Username, 
    string Login, 
    string Password
    );