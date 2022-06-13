using Microsoft.AspNetCore.Mvc;

namespace Demo.AzKeyVault.Identity.API.Controllers;

[ApiController]
[Route("[controller]")]
public class KeyVaultsController : ControllerBase
{

    [HttpGet()]
    public ActionResult Get()
    {
        return new JsonResult(new { success = true, message = "OK" });
    }
}
