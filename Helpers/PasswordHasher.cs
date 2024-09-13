using Microsoft.AspNetCore.Identity;
using BCrypt.Net;

public static class PasswordHelper
{
    public static string HashPassword(string password)
    {
        return BCrypt.Net.BCrypt.HashPassword(password);
    }
}