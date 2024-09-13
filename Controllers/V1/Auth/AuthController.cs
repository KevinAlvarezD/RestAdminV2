using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using RestAdminV2.Models;
using RestAdminV2.Services;
using BCrypt.Net;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("login")]
    public IActionResult Login([FromBody] LoginModel login)
    {
        if (login == null)
        {
            return BadRequest("Invalid login request");
        }

        // Verificar que _userService no sea nulo
        if (_userService == null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "User service not initialized");
        }

        // Verificar que el resultado de _userService.GetUserByEmail no sea nulo
        var user = _userService.GetUserByEmail(login.Email);
        if (user == null)
        {
            return Unauthorized("User not found");
        }

        // Verificar que la contraseña sea válida
        if (!VerifyPassword(login.Password, user.PasswordHash))
        {
            return Unauthorized("Invalid password");
        }

        var claims = new[]
        {
        new Claim(ClaimTypes.Name, user.Name),
    };

        var token = new JwtSecurityToken(
            issuer: Environment.GetEnvironmentVariable("JWT_ISSUER"),
            audience: Environment.GetEnvironmentVariable("JWT_AUDIENCE"),
            claims: claims,
            expires: DateTime.UtcNow.AddMinutes(30),
            signingCredentials: new SigningCredentials(
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Environment.GetEnvironmentVariable("JWT_SECRET_KEY"))),
                SecurityAlgorithms.HmacSha256
            )
        );

        return Ok(new
        {
            Token = new JwtSecurityTokenHandler().WriteToken(token),
            user.Email,
            user.Name,
            user.RoleId
        });
    }

    // Método para verificar la contraseña
    private bool VerifyPassword(string password, string passwordHash)
{
    if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordHash))
    {
        return false; // O maneja el error de manera apropiada
    }

    return BCrypt.Net.BCrypt.Verify(password, passwordHash);
}
}