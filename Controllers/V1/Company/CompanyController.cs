using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
namespace RestAdmin.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public partial class CompanyController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public CompanyController(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}