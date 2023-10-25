using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Amy_Cherrez_Examen1P.Data;
using Amy_Cherrez_Examen1P.Models;

namespace Amy_Cherrez_Examen1P.Controllers
{
    public class AmyCherrez_TablaFacturaController : Controller
    {
        private readonly Amy_Cherrez_Examen1PContext _context;

        public AmyCherrez_TablaFacturaController(Amy_Cherrez_Examen1PContext context)
        {
            _context = context;
        }

        // GET: AmyCherrez_TablaFactura
        public async Task<IActionResult> Index()
        {
              return _context.AmyCherrez_TablaFactura != null ? 
                          View(await _context.AmyCherrez_TablaFactura.ToListAsync()) :
                          Problem("Entity set 'Amy_Cherrez_Examen1PContext.AmyCherrez_TablaFactura'  is null.");
        }

        // GET: AmyCherrez_TablaFactura/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.AmyCherrez_TablaFactura == null)
            {
                return NotFound();
            }

            var amyCherrez_TablaFactura = await _context.AmyCherrez_TablaFactura
                .FirstOrDefaultAsync(m => m.ID == id);
            if (amyCherrez_TablaFactura == null)
            {
                return NotFound();
            }

            return View(amyCherrez_TablaFactura);
        }

        // GET: AmyCherrez_TablaFactura/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: AmyCherrez_TablaFactura/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,AmProducto,AmDescription_Producto,AmPagoEfectivo,AmPrecio")] AmyCherrez_TablaFactura amyCherrez_TablaFactura)
        {
            if (ModelState.IsValid)
            {
                _context.Add(amyCherrez_TablaFactura);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(amyCherrez_TablaFactura);
        }

        // GET: AmyCherrez_TablaFactura/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.AmyCherrez_TablaFactura == null)
            {
                return NotFound();
            }

            var amyCherrez_TablaFactura = await _context.AmyCherrez_TablaFactura.FindAsync(id);
            if (amyCherrez_TablaFactura == null)
            {
                return NotFound();
            }
            return View(amyCherrez_TablaFactura);
        }

        // POST: AmyCherrez_TablaFactura/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,AmProducto,AmDescription_Producto,AmPagoEfectivo,AmPrecio")] AmyCherrez_TablaFactura amyCherrez_TablaFactura)
        {
            if (id != amyCherrez_TablaFactura.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(amyCherrez_TablaFactura);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AmyCherrez_TablaFacturaExists(amyCherrez_TablaFactura.ID))
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
            return View(amyCherrez_TablaFactura);
        }

        // GET: AmyCherrez_TablaFactura/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.AmyCherrez_TablaFactura == null)
            {
                return NotFound();
            }

            var amyCherrez_TablaFactura = await _context.AmyCherrez_TablaFactura
                .FirstOrDefaultAsync(m => m.ID == id);
            if (amyCherrez_TablaFactura == null)
            {
                return NotFound();
            }

            return View(amyCherrez_TablaFactura);
        }

        // POST: AmyCherrez_TablaFactura/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.AmyCherrez_TablaFactura == null)
            {
                return Problem("Entity set 'Amy_Cherrez_Examen1PContext.AmyCherrez_TablaFactura'  is null.");
            }
            var amyCherrez_TablaFactura = await _context.AmyCherrez_TablaFactura.FindAsync(id);
            if (amyCherrez_TablaFactura != null)
            {
                _context.AmyCherrez_TablaFactura.Remove(amyCherrez_TablaFactura);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AmyCherrez_TablaFacturaExists(int id)
        {
          return (_context.AmyCherrez_TablaFactura?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
