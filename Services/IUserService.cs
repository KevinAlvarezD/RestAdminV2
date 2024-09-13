using RestAdminV2.Models;

namespace RestAdminV2.Services
{
    public interface IUserService
    {
        User GetUserByEmail(string email);
    }
}