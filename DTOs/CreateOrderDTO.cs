using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAdminV2.Models;

namespace RestAdminV2.DTOs;

public class CreateOrderDTO
{
    public int? TablesId { get; set; }
    public OrderStatus Status { get; set; }
    public string Observations { get; set; }
    public List<OrderProductDTO> OrderProducts { get; set; }
}