using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class OrderedController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public OrderedController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}