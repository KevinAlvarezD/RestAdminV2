using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAdminV2.Models;

namespace RestAdminV2.DTOs
{
    public class OrderDTO
    {
        public int Id { get; set; }
        public string Observations { get; set; }
        public OrderStatus Status { get; set; }
        public int? TablesId { get; set; }
        public string TableName { get; set; }
        public List<ProductDTO> Products { get; set; }
    }
}