using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.DTOs
{
    public class InvoiceDTO
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public DateTime DateInvoice { get; set; }
        public string Observations { get; set; }
        public double Total { get; set; }
        public IEnumerable<ProductDTO> Products { get; set; }
    }
}