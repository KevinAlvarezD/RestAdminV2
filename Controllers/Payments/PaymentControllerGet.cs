using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class PaymentController
    {
        // GET: api/payment
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayments()
        {
            var payments = await _context.Payments.Include(i => i.Invoice).ThenInclude(o => o.Ordered).ThenInclude(o => o.Customer).Include(i => i.Invoice).ThenInclude(o => o.Ordered).ThenInclude(o => o.Table).ToListAsync();
            return Ok(payments);
        }

        // GET: api/payment/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPayment(int id)
        {
            var payment = await _context.Payments.Include(i => i.Invoice).FirstOrDefaultAsync(i => i.IdPayment == id);

            if (payment == null)
            {
                return NotFound();
            }

            return Ok(payment);
        }
    }
}