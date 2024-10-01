using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MoneyTransactions.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class InfoController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    { 
        return Ok("I am Authorize");
    }
}