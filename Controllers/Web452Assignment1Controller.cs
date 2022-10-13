using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Web452Assignment1.Data;
using Web452Assignment1.Models;

namespace Web452Assignment1.Controllers
{
    public class Web452Assignment1Controller : Controller
    {
        private readonly Web452Assignment1Context _context;

        public Web452Assignment1Controller(Web452Assignment1Context context)
        {
            _context = context;
        }

        // GET: Web452Assignment1
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bed.ToListAsync());
        }

        // GET: Web452Assignment1/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bed = await _context.Bed
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bed == null)
            {
                return NotFound();
            }

            return View(bed);
        }

        // GET: Web452Assignment1/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Web452Assignment1/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Image,Price,Type,Color,Size,Designer,CustomerReview")] Bed bed)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bed);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bed);
        }

        // GET: Web452Assignment1/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bed = await _context.Bed.FindAsync(id);
            if (bed == null)
            {
                return NotFound();
            }
            return View(bed);
        }

        // POST: Web452Assignment1/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Image,Price,Type,Color,Size,Designer,CustomerReview")] Bed bed)
        {
            if (id != bed.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bed);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BedExists(bed.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(bed);
        }

        // GET: Web452Assignment1/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bed = await _context.Bed
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bed == null)
            {
                return NotFound();
            }

            return View(bed);
        }

        // POST: Web452Assignment1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bed = await _context.Bed.FindAsync(id);
            _context.Bed.Remove(bed);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BedExists(int id)
        {
            return _context.Bed.Any(e => e.Id == id);
        }
    }
}
