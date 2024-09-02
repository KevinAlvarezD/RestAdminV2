using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdmin.Models;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerControllerGet : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CustomerControllerGet(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Customer
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        // GET: api/Customer/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }
    }
}