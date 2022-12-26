namespace JWTRefreshToken.NET6._0.Auth.Model
{
    //which will be used to pass access token and refresh token into the refresh method of the
    //authenticate controller.
    public class TokenModel
    {
        public string? AccessToken { get; set; }
        public string? RefreshToken { get; set; }
    }
}
