namespace authWebApi.Authentication;

public record RegisterRequest(string UserName, string Password, string Email);