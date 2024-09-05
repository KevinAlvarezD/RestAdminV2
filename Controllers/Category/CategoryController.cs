using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
namespace RestAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class CategoryController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}