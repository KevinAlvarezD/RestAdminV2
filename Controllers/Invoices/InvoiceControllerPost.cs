using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    public partial class InvoiceController : ControllerBase
    {
      
        // Constructor para inyección de dependencias
        public InvoiceController(ApplicationDbContext context, InvoiceService invoiceService)
        {
            _context = context;
            _invoiceService = invoiceService;
        }

        // POST: api/invoice
        [HttpPost]
        public async Task<ActionResult<Invoice>> CreateInvoice([FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                // Generar el PDF para la factura
                byte[] pdfFile = _invoiceService.GenerateInvoicePdf(invoice);

                // Asignar el PDF al modelo de factura
                invoice.PdfFile = pdfFile;

                // Agregar la factura a la base de datos
                _context.Invoices.Add(invoice);
                await _context.SaveChangesAsync();

                // Retornar la respuesta con la ubicación de la nueva factura
                return CreatedAtAction(nameof(GetInvoice), new { id = invoice.IdInvoice }, invoice);
            }
            catch (Exception ex)
            {
                // Manejo de errores
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}