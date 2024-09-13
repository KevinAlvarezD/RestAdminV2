using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAdminV2.Models;

namespace RestAdminV2.DTOs
{
    public class PreOrderDTO
    {
        public int OrderId { get; set; }
        public List<OrderProduct> OrderProducts { get; set; }

        public double CalculateTotal()
        {
            return OrderProducts.Sum(op => op.Product.Price * op.Quantity);
        }
    }
}