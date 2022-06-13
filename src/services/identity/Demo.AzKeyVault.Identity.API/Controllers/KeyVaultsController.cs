using Demo.AzKeyVault.Identity.API.Providers;
using Microsoft.AspNetCore.Mvc;

namespace Demo.AzKeyVault.Identity.API.Controllers;

[ApiController]
[Route("[controller]")]
public class KeyVaultsController : ControllerBase
{
    private readonly ISecretProvider secretProvider;

    public KeyVaultsController(ISecretProvider secretProvider)
    {
        this.secretProvider = secretProvider;
    }

    [HttpGet()]
    public async Task<ActionResult> Get()
    {
        var secret = await secretProvider.GetSecret("key");
        if (string.IsNullOrEmpty(secret))
            return NotFound();
        return Ok(secret);
    }
}
