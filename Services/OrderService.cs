using RestAdminV2.Models;
using RestAdminV2.DTOs;
using Microsoft.EntityFrameworkCore;

namespace RestAdminV2.Services
{
    public class OrderService
    {
        private readonly ApplicationDbContext _context;

        public OrderService(ApplicationDbContext context)
        {
            _context = context;
        }

        public PreOrderDTO GetPreOrder(int orderId)
        {
            var orderProducts = _context.OrderProducts
                .Where(op => op.OrderId == orderId)
                .Include(op => op.Product)
                .ToList();

            var preOrder = new PreOrderDTO
            {
                OrderId = orderId,
                OrderProducts = orderProducts
            };

            return preOrder;
        }

        public void CreatePreInvoiceFromOrder(int orderId)
        {
            var preOrder = GetPreOrder(orderId);
            var total = preOrder.CalculateTotal();

            var preInvoice = new PreInvoice
            {
                OrderId = orderId,
                Total = total,
                DateInvoice = DateTime.Now,
                Observations = "Generated from order"
            };

            _context.PreInvoices.Add(preInvoice);
            _context.SaveChanges();
        }
    }
}