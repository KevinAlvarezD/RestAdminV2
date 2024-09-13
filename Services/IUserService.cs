using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAdminV2.Models;

namespace RestAdminV2.Services
{
    public interface IUserService
    {
        User GetUserByEmail(string email);
    }
}