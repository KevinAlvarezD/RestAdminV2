using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdmin.Controllers
{
     public partial class CompanyController
    {
        // POST: api/Categories
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company Company)
        {
            _context.Companys.Add(Company);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompany), new { id = Company.Id }, Company);
        }
    }
}