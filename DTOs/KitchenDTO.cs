using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAdminV2.Models;

namespace RestAdminV2.DTOs
{
    public class KitchenDTO
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public OrderKitchenDTO Order { get; set; }
    }
}