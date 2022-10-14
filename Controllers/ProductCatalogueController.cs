using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Web452Assignment1.Data;
using Web452Assignment1.Models;

namespace Web452Assignment1.Controllers
{
    public class ProductCatalogueController : Controller
    {
        private readonly ILogger<ProductCatalogueController> _logger;

        private readonly Web452Assignment1Context _context;

        public ProductCatalogueController(Web452Assignment1Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Bed.ToListAsync());
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

