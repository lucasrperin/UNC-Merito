﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MeritoHealth.Data;
using MeritoHealth.Models;

namespace MeritoHealth.Controllers
{
    public class AlergiasController : Controller
    {
        private readonly MeritoHealthContext _context;

        public AlergiasController(MeritoHealthContext context)
        {
            _context = context;
        }

        // GET: Alergias
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alergia.ToListAsync());
        }

        // GET: Alergias/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alergia = await _context.Alergia
                .FirstOrDefaultAsync(m => m.IdAlergia == id);
            if (alergia == null)
            {
                return NotFound();
            }

            return View(alergia);
        }

        // GET: Alergias/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alergias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdAlergia,Nome,Descricao")] Alergia alergia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alergia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alergia);
        }

        // GET: Alergias/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alergia = await _context.Alergia.FindAsync(id);
            if (alergia == null)
            {
                return NotFound();
            }
            return View(alergia);
        }

        // POST: Alergias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdAlergia,Nome,Descricao")] Alergia alergia)
        {
            if (id != alergia.IdAlergia)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alergia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlergiaExists(alergia.IdAlergia))
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
            return View(alergia);
        }

        // GET: Alergias/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alergia = await _context.Alergia
                .FirstOrDefaultAsync(m => m.IdAlergia == id);
            if (alergia == null)
            {
                return NotFound();
            }

            return View(alergia);
        }

        // POST: Alergias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alergia = await _context.Alergia.FindAsync(id);
            if (alergia != null)
            {
                _context.Alergia.Remove(alergia);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlergiaExists(int id)
        {
            return _context.Alergia.Any(e => e.IdAlergia == id);
        }
    }
}
