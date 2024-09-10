using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
namespace RestAdmin.Controllers
{
    public partial class CompanyController
    {
        // GET: api/Categories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanys()
        {
            return await _context.Companys.ToListAsync();
        }

        //Get: api/Categories
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var Company = await _context.Companys.FindAsync(id);
            if (Company == null)
            {
                return NotFound();
            }
            return Company;
        }
       
    }
}

