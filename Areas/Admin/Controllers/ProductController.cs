using Microsoft.AspNetCore.Mvc;
using QLDienThoai.Models;

namespace QLDienThoai.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        
        private readonly QldienThoaiContext _context;
        public ProductController(QldienThoaiContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
