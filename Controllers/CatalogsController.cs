using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Test_Task.Models;

namespace Test_Task.Controllers
{
    public class CatalogsController : Controller
    {
        private readonly CatalogContext _context;

        public CatalogsController(CatalogContext context)
        {
            _context = context;
        }

        // GET: Catalogs
        public async Task<IActionResult> Index()
        {
            var catalogContext = _context.Catalogs.Where(c => c.ParentCatalog==null);
            return View(await catalogContext.ToListAsync());
        }

        // GET: Catalogs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Catalogs == null)
            {
                return NotFound();
            }

            var catalog = await _context.Catalogs
                .Include(c => c.ChildCatalogs)
                .FirstOrDefaultAsync(m => m.CatalogId == id);
            if (catalog == null)
            {
                return NotFound();
            }

            return View(catalog);
        }



    }
}
