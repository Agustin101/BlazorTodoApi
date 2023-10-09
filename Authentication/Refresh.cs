namespace authWebApi.Authentication;

public record Refresh
{
  public required string AccessToken { get; set; }
  public required string RefreshToken { get; set; }
}