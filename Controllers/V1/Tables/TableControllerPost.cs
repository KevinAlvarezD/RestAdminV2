using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class TablesController : ControllerBase
    {
        // POST: api/tables
        [HttpPost]
        [SwaggerOperation(
            Summary = "Create a new table",
            Description = "Creates a new table and adds it to the database."
        )]
        
        [SwaggerResponse(201, "The table was created successfully.")]
        [SwaggerResponse(400, "If the request data is invalid.")]
        [SwaggerResponse(500, "If there was an internal error while creating the table.")]
        public async Task<ActionResult<Tables>> CreateTables([FromBody] Tables tables)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Tables.Add(tables);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTables), new { id = tables.Id }, tables);
        }
    }
}
