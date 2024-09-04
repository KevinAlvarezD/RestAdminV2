using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using RestAdminV2.Models;


public class InvoiceService
{
    public byte[] GenerateInvoicePdf(Invoice invoice)
    {
        using (var memoryStream = new MemoryStream())
        {
            // Crear el PdfWriter con el MemoryStream
            using (var writer = new PdfWriter(memoryStream))
            {
                // Crear el documento PDF
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);

                    // Añadir el contenido al documento
                    document.Add(new Paragraph($"Invoice ID: {invoice.IdInvoice}"));
                    document.Add(new Paragraph($"Order ID: {invoice.IdOrder}"));
                    document.Add(new Paragraph($"Date: {invoice.DateInvoice.ToShortDateString()}"));
                    document.Add(new Paragraph($"Total: {invoice.Total:C}"));

                    // Cerrar el documento
                    document.Close();
                }
            }
            // Retornar el PDF como un array de bytes
            return memoryStream.ToArray();
        }
    }
}