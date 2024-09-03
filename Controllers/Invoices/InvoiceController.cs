using Microsoft.AspNetCore.Mvc;
using RestAdminV2.Models;

namespace RestAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public partial class InvoiceController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly InvoiceService _invoiceService;

        public InvoiceController(ApplicationDbContext context)
        {
            _context = context;
            _invoiceService = new InvoiceService();
        }
    }
}