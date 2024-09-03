using iTextSharp.text;
using iTextSharp.text.pdf;
using RestAdminV2.Models;


public class InvoiceService
{
    public byte[] GenerateInvoicePdf(Invoice invoice)
    {
        using (var memoryStream = new MemoryStream())
        {
            using (var writer = new PdfWriter())
            using (var pdf = new PdfDocument(writer))
            using (var document = new Document(pdf))
            {
                document.Add(new Paragraph($"Invoice ID: {invoice.IdInvoice}"));
                document.Add(new Paragraph($"Order ID: {invoice.IdOrder}"));
                document.Add(new Paragraph($"Date: {invoice.DateInvoice.ToShortDateString()}"));
                document.Add(new Paragraph($"Total: {invoice.Total:C}"));

                // Añade más detalles según sea necesario
            }
            return memoryStream.ToArray();
        }
    }
}