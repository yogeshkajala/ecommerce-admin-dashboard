using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EcommerceAdmin.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class SecuredController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new 
        { 
            Message = "You have successfully authenticated via the configured connector!", 
            User = User.Identity?.Name ?? "Unknown" 
        });
    }
}
