using Demo.AzKeyVault.Identity.API.Configurations;
using Microsoft.AspNetCore.Mvc;

namespace Demo.AzKeyVault.Identity.API.Controllers;

[ApiController]
[Route("[controller]")]
public class KeyVaultsController : ControllerBase
{
    private readonly IKeyVaultManager keyVaultManager;

    public KeyVaultsController(IKeyVaultManager keyVaultManager)
    {
        this.keyVaultManager = keyVaultManager;
    }

    [HttpGet()]
    public async Task<ActionResult> Get()
    {
        var secret = await keyVaultManager.GetSecret("key");
        if (string.IsNullOrEmpty(secret))
            return NotFound();
        return Ok(secret);
    }
}
