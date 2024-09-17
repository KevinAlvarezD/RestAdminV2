using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAdminV2.DTOs;
using RestAdminV2.Models;
using Swashbuckle.AspNetCore.Annotations;
namespace RestAdmin.Controllers
{
    public partial class KitchenController
    {
        // GET: api/Kitchen
        [HttpGet]
        [SwaggerOperation(
            Summary = "Return all kitchens",
            Description = "Retrieves a list of all kitchens along with their associated orders and kitchen items."
        )]

        [SwaggerResponse(200, "A list of kitchens with their details.", typeof(IEnumerable<KitchenDTO>))]
        [SwaggerResponse(500, "If an error occurs while retrieving the kitchens.")]

        public async Task<ActionResult<IEnumerable<KitchenDTO>>> GetKitchen()
        {
            var kitchens = await _context.Kitchens
                .Include(k => k.Order)
                .ThenInclude(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .Include(k => k.KitchenItems)
                .ThenInclude(ki => ki.Product)
                .ToListAsync();

            var kitchenDTOs = kitchens.Select(k => new KitchenDTO
            {
                Id = k.Id,
                OrderId = k.OrderId,
                Order = new OrderKitchenDTO
                {
                    Observations = k.Order?.Observations,
                    TablesId = (int)(k.Order?.TablesId),
                    Products = k.KitchenItems?.Select(ki => new ProductKitchenDTO
                    {
                        Name = ki.Product?.Name,
                        Quantity = ki.Quantity,
                    }).ToList() ?? new List<ProductKitchenDTO>()
                }
            }).ToList();

            return Ok(kitchenDTOs);
        }



        // GET: api/Kitchen/5
        [HttpGet("{id}")]

        [SwaggerOperation(
            Summary = "Return a kitchen by ID",
            Description = "Return a specific kitchen by its ID, along with its associated order and kitchen items."
        )]

        [SwaggerResponse(200, "The details of the specified kitchen.", typeof(KitchenDTO))]
        [SwaggerResponse(404, "If the kitchen with the specified ID is not found.")]
        [SwaggerResponse(500, "If an error occurs while retrieving the kitchen.")]
        public async Task<ActionResult<KitchenDTO>> GetKitchen(int id)
        {
            var kitchen = await _context.Kitchens
                .Include(k => k.Order)
                .ThenInclude(o => o.OrderProducts)
                .Include(k => k.KitchenItems)
                .FirstOrDefaultAsync(k => k.Id == id);

            if (kitchen == null)
            {
                return NotFound();
            }

            var kitchenDTO = new KitchenDTO
            {
                Id = kitchen.Id,
                OrderId = kitchen.OrderId,
                Order = new OrderKitchenDTO
                {
                    Observations = kitchen.Order.Observations,
                    TablesId = kitchen.Order.TablesId,
                    Products = kitchen.KitchenItems.Select(ki => new ProductKitchenDTO
                    {
                        Name = ki.Product.Name,
                        Quantity = ki.Quantity,
                    }).ToList()
                }
            };

            return Ok(kitchenDTO);
        }

    }
}

