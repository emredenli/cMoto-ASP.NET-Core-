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
using motocycleApp.Models;

namespace motocycleApp.Controllers
{
    public class VehiclesController : Controller
    {
        private readonly motocycleDbContext _context;

        public VehiclesController(motocycleDbContext context)
        {
            _context = context;
        }

        [Authorize]
        // GET: Vehicles
        public async Task<IActionResult> Index()
        {
            return View(await _context.Vehicle.ToListAsync());
        }

        //public async Task<IActionResult> Add()
        //{
        //    return View(await _context.Vehicle.ToListAsync());
        //}



        public IActionResult Add(int vehicle1, int vehicle2)
        {
            ComparePageModel model = new ComparePageModel();

            model.Vehicle1 = GenerateVehicleDetailPageModel(vehicle1);
            model.Vehicle2 = GenerateVehicleDetailPageModel(vehicle2);

            return View(model);

        }

        public VehicleDetailPageModel GenerateVehicleDetailPageModel(int id)
        {
            VehicleDetailPageModel model = new VehicleDetailPageModel();
            Vehicle vehicle = _context.Vehicle.FirstOrDefault(v => v.VehicleId == id);
            model.Vehicle = vehicle;

            Dimension dimension = _context.Dimension.FirstOrDefault(v => v.VehicleId == vehicle.VehicleId);
            if (dimension != null)
                model.Dimension = dimension;

            Engine engine = _context.Engine.FirstOrDefault(v => v.VehicleId == vehicle.VehicleId);
            if (engine != null)
                model.Engine = engine;

            Image image = _context.Image.FirstOrDefault(v => v.VehicleId == vehicle.VehicleId);
            if (image != null)
                model.Image = image;
            else
                model.Image.ImageName = "hondaMotocycle.jpg";

            return model;
        }


        public IActionResult Detail(int id)
        {
            VehicleDetailPageModel model = new VehicleDetailPageModel();

            Vehicle vehicle = _context.Vehicle.FirstOrDefault(v => v.VehicleId == id);
            if (vehicle == null)
                return NotFound();
           
            model.Vehicle = vehicle;

            Dimension dimension = _context.Dimension.FirstOrDefault(v => v.VehicleId == vehicle.VehicleId);
            if (dimension != null)
                model.Dimension = dimension;

            Engine engine = _context.Engine.FirstOrDefault(v => v.VehicleId == vehicle.VehicleId);
            if (engine != null)
                model.Engine = engine;

            Image image = _context.Image.FirstOrDefault(v => v.VehicleId == vehicle.VehicleId);
            if (image != null)
                model.Image = image;
            else
                model.Image.ImageName = "hondaMotocycle.jpg";

            return View(model);

        }

        public async Task<IActionResult> List(string search, int brandid, int categoryid)
        {
            VehicleListPageModel viewModel = new VehicleListPageModel();

            #region Create motor list
            List<VehicleDetailPageModel> motors = new List<VehicleDetailPageModel>();
            List<Vehicle> vehicles;

            var query = _context.Vehicle.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search))
            {
                query = query.Where(c => EF.Functions.Like(c.Name, "%" + search + "%"));
                viewModel.Search = search;
            }
            if(brandid > decimal.Zero)
            {
                query = query.Where(c => c.BrandId == brandid);
                viewModel.BrandId = brandid;
            }

            if (categoryid > decimal.Zero)
            {
                query = query.Where(c => c.CategoryId == categoryid);
                viewModel.CategoryId = categoryid;
            }

            vehicles = await query.ToListAsync();

            foreach (var vehicle in vehicles)
            {
                VehicleDetailPageModel current = new VehicleDetailPageModel();
                current.Vehicle = vehicle;
                Image image = _context.Image.FirstOrDefault(v => v.VehicleId == vehicle.VehicleId);
                current.Image = image;

                motors.Add(current);
            }

            viewModel.VehicleDetailPageModels = motors;
            #endregion

            #region Create Brand List
            List<Brand> brands = await _context.Brand.ToListAsync();

            viewModel.Brands = brands;
            #endregion

            #region Create Category List
            var categories = await _context.Category.ToListAsync();

            viewModel.Categories = categories;
            #endregion


            #region Title
            viewModel.Title = "<h1><b>Motorcycles</b> {BrandName}</h1>";
            if(brandid > decimal.Zero)
            {
                Brand brand = _context.Brand.Where(b => b.BrandId == brandid).FirstOrDefault();
                if(brand != null)
                {
                    viewModel.Title = viewModel.Title.Replace("{BrandName}", $"<small><em>{brand.BrandName}</em></small>");
                }
                else
                {
                    viewModel.Title = viewModel.Title.Replace("{BrandName}", "<small><em>Revs Your Heart</em></small>");
                }
            }
            else
            {
                viewModel.Title = viewModel.Title.Replace("{BrandName}", "<small><em>Revs Your Heart</em></small>");
            }

            #endregion

            return View(viewModel);
        }

        // GET: Vehicles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.VehicleId == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehicleId,CategoryId,BrandId,Name,Year")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vehicle);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VehicleId,CategoryId,BrandId,Name,Year")] Vehicle vehicle)
        {
            if (id != vehicle.VehicleId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.VehicleId))
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
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .FirstOrDefaultAsync(m => m.VehicleId == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicle.Any(e => e.VehicleId == id);
        }
    }
}
