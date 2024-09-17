using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAdminV2.DTOs
{
    public class OrderKitchenDTO
    {
        public string Observations { get; set; }
        public int TablesId { get; set; }
        public List<ProductKitchenDTO> Products { get; set; }
    }
}