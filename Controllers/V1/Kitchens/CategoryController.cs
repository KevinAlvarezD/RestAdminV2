using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
namespace RestAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class KitchenController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public KitchenController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}