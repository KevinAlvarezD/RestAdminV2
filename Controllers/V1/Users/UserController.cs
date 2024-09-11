using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public partial class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public UserController (ApplicationDbContext context)
        {
            _context = context;
        }
    }
}