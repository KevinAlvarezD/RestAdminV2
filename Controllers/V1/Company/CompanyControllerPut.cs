using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
   public partial class CompanyController
    {

         /// <summary>
        /// Updates an existing Company by its ID.
        /// </summary>
        
        /// <remarks>
        /// This endpoint allows you to update an existing Company in the database. If the Company with the specified ID does not exist, a 404 (Not Found) status code is returned. If the request data is invalid or does not match the ID, a 400 (Bad Request) status code is returned.
        /// </remarks>
        
        /// <param name="id">
        /// The ID of the Company to update.
        /// </param>
        
        /// <param name="Company">
        /// The category object containing the updated data.
        /// </param>
        
        /// <response code="204">If the Company was updated successfully</response>
        /// <response code="400">If the Company ID does not match or the request data is invalid</response>
        /// <response code="404">If the Company with the specified ID was not found</response>
        /// <response code="500">If there was an internal error while updating the Company</response>
        
        // PUT: api/companies/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company Company)
        {
            if (id != Company.Id)
            {
                return BadRequest("Company ID mismatch.");
            }

            _context.Entry(Company).State = EntityState.Modified;

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