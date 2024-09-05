using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class EmployeeController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController (ApplicationDbContext context)
        {
            _context = context;
        }
    }
}