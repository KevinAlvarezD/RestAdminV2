using Microsoft.AspNetCore.Mvc;

namespace RestAdmin.Controllers
{
    public partial class CompanyController{
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