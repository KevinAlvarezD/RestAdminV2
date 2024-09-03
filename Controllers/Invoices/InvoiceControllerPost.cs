using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;
using Microsoft.EntityFrameworkCore;

namespace RestAdmin.Controllers
{
    public partial class InvoiceController : ControllerBase
    {
        // POST: api/invoice
        [HttpPost]
        public async Task<IActionResult> CreateInvoice([FromBody] Invoice invoice)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var ordered = await _context.Ordereds.FindAsync(invoice.IdOrder);
                if (ordered == null)
                {
                    return NotFound($"Order with ID {invoice.IdOrder} not found.");
                }

                invoice.Ordered = ordered;

                // Generar el PDF usando el servicio actualizado a iText7
                byte[] pdfFile = _invoiceService.GenerateInvoicePdf(invoice);

                // Almacenar el archivo PDF generado en la propiedad del modelo
                invoice.PdfFile = pdfFile;

                // Agregar y guardar el nuevo registro de factura en la base de datos
                _context.Invoices.Add(invoice);
                await _context.SaveChangesAsync();

                // Devolver el archivo PDF como respuesta
                return File(pdfFile, "application/pdf", "invoice.pdf");
            }
            catch (DbUpdateException dbEx)
            {
                return StatusCode(500, $"Database update error: {dbEx.Message}");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }
    }
}