using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
namespace RestAdmin.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public partial class KitchenController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public KitchenController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}