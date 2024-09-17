using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdmin.Controllers
{
    public partial class CompanyController : ControllerBase
    {
        [HttpDelete("{id}")]
        [SwaggerOperation(
            Summary = "Deletes a company by ID",
            Description = "This endpoint allows you to delete a company from the database. If the company does not exist, a 404 (Not Found) status code is returned."
        )]
        
        [SwaggerResponse(204, "The company was successfully deleted.")]
        [SwaggerResponse(404, "If the company with the specified ID is not found.")]
        [SwaggerResponse(500, "An internal server error occurred.")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var company = await _context.Companys.FindAsync(id);
            if (company == null)
            {
                return NotFound();
            }

            _context.Companys.Remove(company);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
