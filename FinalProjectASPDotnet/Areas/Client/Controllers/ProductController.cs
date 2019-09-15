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



        [Route("Product/{category}/{ProductName}")]
        public async Task<IActionResult> Details(string ProductName ,string category)
        {
            if (ProductName == null)
            {
                return NotFound();
            }
            var product = await _context.Product
                .Include(p => p.category)
                .FirstOrDefaultAsync(p => p.ProductName.Contains(ProductName));
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        public  async Task<IActionResult> Shop(int? page,int? category,string SearchInput)
        {
            int pageSize = 6;
            if (page == null) page = 1;
            var Context = _context.Product.Include(p => p.category).OrderBy(p => p.ProductId);
            if (category != null) Context = Context.Where(p => p.CateId == category).OrderBy(p => p.ProductId);
            if (SearchInput != null) Context = Context.Where(p => p.ProductName.Contains(SearchInput)).OrderBy(p => p.ProductId);
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
