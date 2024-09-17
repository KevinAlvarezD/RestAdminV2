using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class TablesController : ControllerBase
    {
        // PUT: api/tables/5
        [HttpPut("{id}")]
        [SwaggerOperation(
            Summary = "Update an existing table",
            Description = "Updates the details of an existing table in the database."
        )]
        
        [SwaggerResponse(204, "The table was updated successfully.")]
        [SwaggerResponse(400, "If the request data is invalid or the table ID in the URL does not match the ID in the body.")]
        [SwaggerResponse(404, "If the table with the specified ID is not found.")]
        [SwaggerResponse(500, "If there was an internal error while updating the table.")]
        public async Task<IActionResult> UpdateTables(int id, [FromBody] Tables tables)
        {
            if (id != tables.Id)
            {
                return BadRequest("Tables ID mismatch.");
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Entry(tables).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TablesExists(id))
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

        private bool TablesExists(int id)
        {
            return _context.Tables.Any(e => e.Id == id);
        }
    }
}
