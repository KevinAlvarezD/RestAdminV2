using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
namespace RestAdmin.Controllers
{
    public partial class CompanyController
    {

        /// <summary>
        /// Return a list of all Company.
        /// </summary>

        /// <remarks>
        /// This endpoint returns a list of all Company available in the database.
        /// </remarks>

        /// <response code="200">Returns the list of Company</response>
        /// <response code="500">If there was an internal error while fetching the Company</response>
        // GET: api/Company
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanys()
        {
            return await _context.Companys.ToListAsync();
        }


        /// <summary>
        /// Return a Company by its ID.
        /// </summary>

        /// <param name="id">
        /// The id of the Company to Return
        /// </param>

        /// <remarks>
        /// This endpoint allows you to fetch a specific Company by providing its ID.
        /// If the Company does not exist, a 404 (Not Found) status code is returned.
        /// </remarks>

        /// <response code="200">Returns the requested Company</response>
        /// <response code="404">If the Company with the specified ID is not found</response>
        /// <response code="500">If there was an internal error while fetching the Company</response>

        //Get: api/Companies
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

