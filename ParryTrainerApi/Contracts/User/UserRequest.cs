namespace ParryTrainerApi.Contracts.User;

public record UserRequest(
    string Username, 
    string Login, 
    string Password
    );