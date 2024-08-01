using System.Security.Claims;
using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;

namespace WebApiSample;

public class CustomAuthenticationScheme : AuthenticationSchemeOptions
{
    public const string Name = "CustomAuthentication";
}

public class CustomAuthenticationHandler : AuthenticationHandler<CustomAuthenticationScheme>
{
    public CustomAuthenticationHandler(IOptionsMonitor<CustomAuthenticationScheme> options, ILoggerFactory logger, UrlEncoder encoder) : base(options, logger, encoder)
    {
    }

    protected override Task<AuthenticateResult> HandleAuthenticateAsync()
    {
        var claims = new[] { new Claim(ClaimTypes.Name, "Test"), new Claim(ClaimTypes.Role, "TestRole") };
        var principal = new ClaimsPrincipal(new ClaimsIdentity(claims, "Custom"));
        var ticket = new AuthenticationTicket(principal, this.Scheme.Name);
        return Task.FromResult(AuthenticateResult.Success(ticket));
    }
}