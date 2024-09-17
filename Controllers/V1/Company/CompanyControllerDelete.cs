using Microsoft.AspNetCore.Mvc;

namespace RestAdmin.Controllers
{
    public partial class CompanyController
    {
        /// <summary>
        /// Deletes a Company specified by its ID.
        /// </summary>

        /// <remarks>
        /// This endpoint allows you to delete a Company from the database. If the Company does not exist, a 404 (Not Found) status code is returned.
        /// </remarks>

        //Delete: api/Company/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            var Companys = await _context.Companys.FindAsync(id);
            if (Companys == null)
            {
                return NotFound();
            }
            _context.Companys.Remove(Companys);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}