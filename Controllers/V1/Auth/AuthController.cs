using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using RestAdminV2.Models;
using RestAdminV2.Services;
using BCrypt.Net;
using Swashbuckle.AspNetCore.Annotations;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    private readonly IUserService _userService;

    public AuthController(IUserService userService)
    {
        _userService = userService;
    }

    // POST: api/auth/login
    [HttpPost("login")]
    [SwaggerOperation(
        Summary = "User login",
        Description = "Logs in a user and returns a JWT token if the credentials are valid."
    )]
    
    [SwaggerResponse(200, "Returns a JWT token along with user information if login is successful.")]
    [SwaggerResponse(400, "If the login request is invalid.")]
    [SwaggerResponse(401, "If the user is not found or the password is invalid.")]
    [SwaggerResponse(500, "If the user service is not initialized.")]
    public IActionResult Login([FromBody] LoginModel login)
    {
        if (login == null)
        {
            return BadRequest("Invalid login request");
        }

        if (_userService == null)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, "User service not initialized");
        }

        var user = _userService.GetUserByEmail(login.Email);
        if (user == null)
        {
            return Unauthorized("User not found");
        }

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

    private bool VerifyPassword(string password, string passwordHash)
    {
        if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(passwordHash))
        {
            return false;
        }

        return BCrypt.Net.BCrypt.Verify(password, passwordHash);
    }
}
