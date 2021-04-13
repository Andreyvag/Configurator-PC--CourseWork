using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Configurator_PC.Models;

namespace Configurator_PC.Controllers
{
    public class ConfiguratorsMVCController : Controller
    {
        private readonly AccessoriesContext _context;

        public ConfiguratorsMVCController(AccessoriesContext context)
        {
            _context = context;
        }

        // GET: ConfiguratorsMVC
        public async Task<IActionResult> Index()
        {
            var accessoriesContext = _context.Configurators.Include(c => c.Cooling).Include(c => c.HardDrive).Include(c => c.Motherboard).Include(c => c.NetworkAdapter).Include(c => c.PowerSupply).Include(c => c.Processor).Include(c => c.RAM).Include(c => c.SSD).Include(c => c.SoundCard).Include(c => c.VideoCard);
            return View(await accessoriesContext.ToListAsync());
        }

        // GET: ConfiguratorsMVC/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configurator = await _context.Configurators
                .Include(c => c.Cooling)
                .Include(c => c.HardDrive)
                .Include(c => c.Motherboard)
                .Include(c => c.NetworkAdapter)
                .Include(c => c.PowerSupply)
                .Include(c => c.Processor)
                .Include(c => c.RAM)
                .Include(c => c.SSD)
                .Include(c => c.SoundCard)
                .Include(c => c.VideoCard)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configurator == null)
            {
                return NotFound();
            }

            return View(configurator);
        }

        // GET: ConfiguratorsMVC/Create
        public IActionResult Create()
        {
            ViewData["CoolingId"] = new SelectList(_context.Coolings, "Id", "Name");
            ViewData["HardDriveId"] = new SelectList(_context.HardDrives, "Id", "Name");
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Name");
            ViewData["NetworkAdapterId"] = new SelectList(_context.NetworkAdapters, "Id", "Name");
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Name");
            ViewData["ProcessorId"] = new SelectList(_context.Processors, "Id", "Name");
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Name");
            ViewData["SSDId"] = new SelectList(_context.SSDs, "Id", "Name");
            ViewData["SoundCardId"] = new SelectList(_context.SoundCards, "Id", "Name");
            ViewData["VideoCardId"] = new SelectList(_context.VideoCards, "Id", "Name");
            return View();
        }

        // POST: ConfiguratorsMVC/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Power,ProcessorId,VideoCardId,MotherboardId,CoolingId,RAMId,SSDId,HardDriveId,PowerSupplyId,SoundCardId,NetworkAdapterId")] Configurator configurator)
        {
            if (ModelState.IsValid)
            {
                _context.Add(configurator);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CoolingId"] = new SelectList(_context.Coolings, "Id", "Id", configurator.CoolingId);
            ViewData["HardDriveId"] = new SelectList(_context.HardDrives, "Id", "Id", configurator.HardDriveId);
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Id", configurator.MotherboardId);
            ViewData["NetworkAdapterId"] = new SelectList(_context.NetworkAdapters, "Id", "Id", configurator.NetworkAdapterId);
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Id", configurator.PowerSupplyId);
            ViewData["ProcessorId"] = new SelectList(_context.Processors, "Id", "Id", configurator.ProcessorId);
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Id", configurator.RAMId);
            ViewData["SSDId"] = new SelectList(_context.SSDs, "Id", "Id", configurator.SSDId);
            ViewData["SoundCardId"] = new SelectList(_context.SoundCards, "Id", "Id", configurator.SoundCardId);
            ViewData["VideoCardId"] = new SelectList(_context.VideoCards, "Id", "Id", configurator.VideoCardId);
            return View(configurator);
        }

        // GET: ConfiguratorsMVC/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configurator = await _context.Configurators.FindAsync(id);
            if (configurator == null)
            {
                return NotFound();
            }
            ViewData["CoolingId"] = new SelectList(_context.Coolings, "Id", "Name", configurator.CoolingId);
            ViewData["HardDriveId"] = new SelectList(_context.HardDrives, "Id", "Name", configurator.HardDriveId);
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Name", configurator.MotherboardId);
            ViewData["NetworkAdapterId"] = new SelectList(_context.NetworkAdapters, "Id", "Name", configurator.NetworkAdapterId);
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Name", configurator.PowerSupplyId);
            ViewData["ProcessorId"] = new SelectList(_context.Processors, "Id", "Name", configurator.ProcessorId);
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Name", configurator.RAMId);
            ViewData["SSDId"] = new SelectList(_context.SSDs, "Id", "Name", configurator.SSDId);
            ViewData["SoundCardId"] = new SelectList(_context.SoundCards, "Id", "Name", configurator.SoundCardId);
            ViewData["VideoCardId"] = new SelectList(_context.VideoCards, "Id", "Name", configurator.VideoCardId);
            return View(configurator);
        }

        // POST: ConfiguratorsMVC/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Power,ProcessorId,VideoCardId,MotherboardId,CoolingId,RAMId,SSDId,HardDriveId,PowerSupplyId,SoundCardId,NetworkAdapterId")] Configurator configurator)
        {
            if (id != configurator.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(configurator);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ConfiguratorExists(configurator.Id))
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
            ViewData["CoolingId"] = new SelectList(_context.Coolings, "Id", "Id", configurator.CoolingId);
            ViewData["HardDriveId"] = new SelectList(_context.HardDrives, "Id", "Id", configurator.HardDriveId);
            ViewData["MotherboardId"] = new SelectList(_context.Motherboards, "Id", "Id", configurator.MotherboardId);
            ViewData["NetworkAdapterId"] = new SelectList(_context.NetworkAdapters, "Id", "Id", configurator.NetworkAdapterId);
            ViewData["PowerSupplyId"] = new SelectList(_context.PowerSupplies, "Id", "Id", configurator.PowerSupplyId);
            ViewData["ProcessorId"] = new SelectList(_context.Processors, "Id", "Id", configurator.ProcessorId);
            ViewData["RAMId"] = new SelectList(_context.RAMs, "Id", "Id", configurator.RAMId);
            ViewData["SSDId"] = new SelectList(_context.SSDs, "Id", "Id", configurator.SSDId);
            ViewData["SoundCardId"] = new SelectList(_context.SoundCards, "Id", "Id", configurator.SoundCardId);
            ViewData["VideoCardId"] = new SelectList(_context.VideoCards, "Id", "Id", configurator.VideoCardId);
            return View(configurator);
        }

        // GET: ConfiguratorsMVC/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var configurator = await _context.Configurators
                .Include(c => c.Cooling)
                .Include(c => c.HardDrive)
                .Include(c => c.Motherboard)
                .Include(c => c.NetworkAdapter)
                .Include(c => c.PowerSupply)
                .Include(c => c.Processor)
                .Include(c => c.RAM)
                .Include(c => c.SSD)
                .Include(c => c.SoundCard)
                .Include(c => c.VideoCard)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (configurator == null)
            {
                return NotFound();
            }

            return View(configurator);
        }

        // POST: ConfiguratorsMVC/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var configurator = await _context.Configurators.FindAsync(id);
            _context.Configurators.Remove(configurator);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ConfiguratorExists(int id)
        {
            return _context.Configurators.Any(e => e.Id == id);
        }
    }
}
