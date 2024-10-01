using Microsoft.AspNetCore.Mvc;
using MoneyTransactions.Api.Models;
using MoneyTransactions.Api.Services;

namespace MoneyTransactions.Api.Controllers;

[Route("api/[controller]/[action]")]
[ApiController]
public class AuthController : ControllerBase
{
    
    
    private readonly AuthenticationService authService;
    public AuthController(AuthenticationService serv)
    {
        authService = serv;
    }

    [HttpPost]
    [ActionName("register")]
    public async Task<IActionResult> Register(RegisterUser user)
    {
        try
        {
            var response = await authService.RegisterNewUser(user);
            if (response)
                return Ok($"User {user.Email} is register successfully");
            return BadRequest(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message); 
        }
    }

    [HttpPost]
    [ActionName("authenticate")]
    public async Task<IActionResult> AuthUser(LoginUser user)
    {
        try
        {
            var response = await authService.Authenticate(user);
            if (response)
                return Ok($"User {user.Email} is authenticated successfully");
            return BadRequest(response);
        }
        catch (Exception ex)
        {
            return BadRequest(ex.Message);
        }
    }
}