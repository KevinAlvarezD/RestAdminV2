using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAdminV2.Models;

namespace RestAdminV2.DTOs;

public class OrderProductDTO
{
    public int ProductId { get; set; }
    public int OrderId { get; set; }
    public int Quantity { get; set; } 
}
