using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class CustomerController
    {
        // POST: api/Customer
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
        }
    }
}