using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdmin.Controllers
{
    public partial class CompanyController : ControllerBase
    {
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Updates an existing company by its ID",
            Description = "This endpoint allows you to update an existing company in the database. If the company with the specified ID does not exist, a 404 (Not Found) status code is returned. If the request data is invalid or does not match the ID, a 400 (Bad Request) status code is returned."
        )]
        
        [SwaggerResponse(204, "The company was updated successfully.")]
        [SwaggerResponse(400, "The company ID does not match or the request data is invalid.")]
        [SwaggerResponse(404, "The company with the specified ID was not found.")]
        [SwaggerResponse(500, "An internal server error occurred while updating the company.")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            if (id != company.Id)
            {
                return BadRequest("Company ID mismatch.");
            }

            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CompanyExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool CompanyExists(int id)
        {
            return _context.Companys.Any(item => item.Id == id);
        }
    }
}
