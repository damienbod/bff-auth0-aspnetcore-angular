using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BffAuth0.Server.Controllers;

[ValidateAntiForgeryToken]
[Authorize(AuthenticationSchemes = CookieAuthenticationDefaults.AuthenticationScheme)]
[ApiController]
[Route("api/[controller]")]
public class DirectApiController : ControllerBase
{
    [HttpGet]
    public async Task<IEnumerable<string>> GetAsync()
    {
        // if you need a delegated access token for downstream APIs
        var accessToken = await HttpContext.GetTokenAsync("access_token");

        return new List<string> { "some data", "more data", "loads of data" };
    }
}
