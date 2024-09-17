using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace RestAdminV2.Controllers
{
    public partial class TablesController : ControllerBase
    {
        // GET: api/tables
        [HttpGet]
        [SwaggerOperation(
            Summary = "Retrieve a list of all tables",
            Description = "Returns a list of all tables available in the database."
        )]
        
        [SwaggerResponse(200, "Returns the list of tables.")]
        [SwaggerResponse(500, "If there was an internal error while fetching the tables.")]
        public async Task<ActionResult<IEnumerable<Tables>>> GetTables()
        {
            var tables = await _context.Tables.ToListAsync();
            return Ok(tables);
        }

        // GET: api/tables/5
        [HttpGet("{id}")]
        [SwaggerOperation(
            Summary = "Retrieve a table by ID",
            Description = "Returns a specific table identified by its ID. Returns 404 if the table with the specified ID is not found."
        )]

        [SwaggerResponse(200, "Returns the details of the table.")]
        [SwaggerResponse(404, "If the table with the specified ID is not found.")]
        [SwaggerResponse(500, "If there was an internal error while fetching the table.")]
        public async Task<ActionResult<Tables>> GetTables(int id)
        {
            var table = await _context.Tables.FindAsync(id);

            if (table == null)
            {
                return NotFound();
            }

            return Ok(table);
        }
    }
}
