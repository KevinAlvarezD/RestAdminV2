using Microsoft.AspNetCore.Mvc;
using RestAdmin.Models;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class EmployeeController
    {
        // POST: api/Employee
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
        }
    }
}