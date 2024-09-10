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
            using (var writer = new PdfWriter(memoryStream))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);

                    document.Add(new Paragraph($"Invoice ID: {invoice.IdInvoice}"));
                    document.Add(new Paragraph($"Order ID: {invoice.OrderId}"));
                    document.Add(new Paragraph($"Date: {invoice.DateInvoice.ToShortDateString()}"));
                    document.Add(new Paragraph($"Total: {invoice.Total:C}"));

                    document.Close();
                }
            }
            return memoryStream.ToArray();
        }
    }
}