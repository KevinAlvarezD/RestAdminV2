using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdmin.Controllers
{
    public partial class CompanyController : ControllerBase
    {
        [HttpGet]
        [SwaggerOperation(
            Summary = "Returns a list of all companies",
            Description = "This endpoint retrieves all companies from the database."
        )]
        [SwaggerResponse(200, "The list of companies was Return successfully.")]
        [SwaggerResponse(500, "An internal server error occurred while fetching the companies.")]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            return await _context.Companys.ToListAsync();
        }

        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Returns a company by its ID",
            Description = "This endpoint fetches a specific company by its ID."
        )]
        [SwaggerResponse(200, "The company was Retunr successfully.")]
        [SwaggerResponse(404, "No company with the specified ID was found.")]
        [SwaggerResponse(500, "An internal server error occurred while fetching the company.")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            var company = await _context.Companys.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }
            return company;
        }
    }
}
