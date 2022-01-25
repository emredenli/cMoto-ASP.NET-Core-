using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using motocycle.Data;
using motocycle.Data.Model;

namespace motocycleApp.Controllers
{
    public class DimensionsController : Controller
    {
        private readonly motocycleDbContext _context;

        public DimensionsController(motocycleDbContext context)
        {
            _context = context;
        }

        [Authorize]
        // GET: Dimensions
        public async Task<IActionResult> Index()
        {
            return View(await _context.Dimension.ToListAsync());
        }

        // GET: Dimensions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimension = await _context.Dimension
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dimension == null)
            {
                return NotFound();
            }

            return View(dimension);
        }

        // GET: Dimensions/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Dimensions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleId,Lenght,Width,Height,DistanceBetweenWheels,SeatHeight,FuelCapacity,Weight")] Dimension dimension)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dimension);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dimension);
        }

        // GET: Dimensions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimension = await _context.Dimension.FindAsync(id);
            if (dimension == null)
            {
                return NotFound();
            }
            return View(dimension);
        }

        // POST: Dimensions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleId,Lenght,Width,Height,DistanceBetweenWheels,SeatHeight,FuelCapacity,Weight")] Dimension dimension)
        {
            if (id != dimension.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dimension);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DimensionExists(dimension.Id))
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
            return View(dimension);
        }

        // GET: Dimensions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var dimension = await _context.Dimension
                .FirstOrDefaultAsync(m => m.Id == id);
            if (dimension == null)
            {
                return NotFound();
            }

            return View(dimension);
        }

        // POST: Dimensions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var dimension = await _context.Dimension.FindAsync(id);
            _context.Dimension.Remove(dimension);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DimensionExists(int id)
        {
            return _context.Dimension.Any(e => e.Id == id);
        }
    }
}
