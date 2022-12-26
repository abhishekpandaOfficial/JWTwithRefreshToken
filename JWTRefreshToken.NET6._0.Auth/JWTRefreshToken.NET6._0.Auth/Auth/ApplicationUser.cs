using Microsoft.AspNetCore.Identity;

namespace JWTRefreshToken.NET6._0.Auth.Auth
{
    //we have extended default Identity user with new properties refresh token and refresh token expiry time.
    public class ApplicationUser:IdentityUser
    {
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
    }
}
