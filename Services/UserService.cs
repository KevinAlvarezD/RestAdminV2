using System.Linq;
using RestAdminV2.Models;

namespace RestAdminV2.Services
{
public class UserService : IUserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public User GetUserByEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
        {
            throw new ArgumentException("Email cannot be null or empty", nameof(email));
        }

        return _context.Users.FirstOrDefault(u => u.Email == email);
    }
}
}