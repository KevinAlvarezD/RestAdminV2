using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using RestAdminV2.Models;

namespace RestAdminV2.DTOs
{
    public class ProductKitchenDTO
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
    }
}