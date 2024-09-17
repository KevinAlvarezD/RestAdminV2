using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;


namespace RestAdmin.Controllers
{
    public partial class CompanyController
    {

        /// <summary>
        /// Creates a new Company.
        /// </summary>

        /// <remarks>
        /// This endpoint allows you to create a new Company in the database. The created Company will be returned in the response.
        /// </remarks>

        /// <param name="Company">
        /// The Company object to be created.
        /// </param>

        /// <response code="201">Returns the created Company along with its ID</response>
        /// <response code="400">If the Company data is invalid or missing</response>
        /// <response code="500">If there was an internal error while creating the Company</response>
        // POST: api/Companies
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company Company)
        {
            _context.Companys.Add(Company);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCompany), new { id = Company.Id }, Company);
        }
    }
}