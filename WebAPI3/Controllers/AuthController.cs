using Microsoft.AspNetCore.Mvc;
using WebAPI3.Services;

namespace WebAPI3.Controllers;

[ApiController]
[Route("api/v1/auth")]
public class AuthController : Controller
{
    [HttpPost]
    public IActionResult Auth(string username, string password)
    {
        if (username == "Violett" && password == "Senai115@")
        {
            var token = TokenService.GenerateToken(new Model.Funcionario(username, 12, null));
            return Ok(token);

        }

        return BadRequest("Usuário ou senha incorretos!");
    }
}
