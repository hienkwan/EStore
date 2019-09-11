using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FinalProjectASPDotnet.Models;
using FinalProjectASPDotnet.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace FinalProjectASPDotnet.Controllers
{
    [Area("Client")]
    public class ProductController : Controller
    {
        private readonly MyDbContext _context;
        public ProductController(MyDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("Product/{category}/{id}")]
        public async Task<IActionResult> Details(int? id,string category)
        {
            if (id == null)
            {
                return NotFound();
            }
            var product = await _context.Product
                .Include(p => p.category)
                .FirstOrDefaultAsync(p => p.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public  async Task<IActionResult> Shop(int? page,int? category)
        {
            int pageSize = 6;
            if (page == null) page = 1;
            var Context = _context.Product.Include(p => p.category).OrderBy(p => p.ProductId);
            if (category != null) Context = Context.Where(p => p.CateId == category).OrderBy(p => p.ProductId);
            //return View(await _context.Product.ToListAsync());
            return View(await Context.ToListAsync()); 
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
