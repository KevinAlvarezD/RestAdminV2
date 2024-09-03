using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdminV2.Controllers
{
    public partial class AdministratorController
    {
        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Administrator>>> GetCustomers()
        {
            return await _context.Administrators.ToListAsync();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Administrator>> GetCustomer(int id)
        {
            var administrator = await _context.Administrators.FindAsync(id);
            if (administrator == null)
            {
                return NotFound();
            }

            return administrator;
        }
    }
}