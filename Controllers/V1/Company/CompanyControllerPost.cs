using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdmin.Controllers
{
    public partial class CompanyController : ControllerBase
    {
        [HttpPost]
        [SwaggerOperation(
            Summary = "Creates a new company",
            Description = "This endpoint allows you to create a new company in the database. The created company will be returned in the response."
        )]

        [SwaggerResponse(201, "The company was created successfully along with its ID.")]
        [SwaggerResponse(400, "The company data is invalid or missing.")]
        [SwaggerResponse(500, "An internal server error occurred while creating the company.")]
        
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            _context.Companys.Add(company);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompany), new { id = company.Id }, company);
        }
    }
}
