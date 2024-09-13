using Microsoft.AspNetCore.Mvc;
using RestAdminV2.DTOs;
using RestAdminV2.Models;


namespace RestAdminV2.Controllers
{
    public partial class OrderController
    {
        // POST: api/Order
       [HttpPost]
public async Task<ActionResult<OrderDTO>> PostOrder(CreateOrderDTO createOrderDTO)
{
    var table = await _context.Tables.FindAsync(createOrderDTO.TablesId);
    if (table == null)
    {
        return BadRequest("Table not found.");
    }

    var order = new Order
    {
        TablesId = createOrderDTO.TablesId,
        Observations = createOrderDTO.Observations,
        Tables = table,
        OrderProducts = new List<OrderProduct>()
    };

    foreach (var orderProductDTO in createOrderDTO.OrderProducts)
    {
        var product = await _context.Products.FindAsync(orderProductDTO.ProductId);
        if (product == null)
        {
            return BadRequest($"Product with ID {orderProductDTO.ProductId} not found.");
        }

        order.OrderProducts.Add(new OrderProduct
        {
            ProductId = product.Id,
            Quantity = orderProductDTO.Quantity,
            Order = order
        });
    }

    _context.Orders.Add(order);
    await _context.SaveChangesAsync();

    var orderDTO = new OrderDTO
    {
        Id = order.Id,
        Observations = order.Observations,
        TablesId = order.TablesId,
        TableName = table.Name,
        Products = order.OrderProducts.Select(op => new ProductDTO
        {
            Id = op.Product.Id,
            Name = op.Product.Name,
            Price = op.Product.Price,
            ImageURL = op.Product.ImageURL,
            Category = op.Product.Category
        }).ToList()
    };

    return CreatedAtAction(nameof(GetOrder), new { id = order.Id }, orderDTO);
}
    }
}