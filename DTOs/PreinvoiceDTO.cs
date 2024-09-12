using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.DTOs
{
    public class PreinvoiceDTO
    {
        public string Observations { get; set; }
        public double Total { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}