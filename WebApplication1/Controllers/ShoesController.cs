using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TippyToe.Models;

namespace TippyToe.Controllers
{
    public class ShoesController : Controller
    {
        private readonly TippyToeContext _context;

        public ShoesController(TippyToeContext context)
        {
            _context = context;
        }

        // GET: Shoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.Shoes.ToListAsync());
        }

        // GET: Shoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoes = await _context.Shoes
                .SingleOrDefaultAsync(m => m.Id == id);
            if (shoes == null)
            {
                return NotFound();
            }

            return View(shoes);
        }

        // GET: Shoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Shoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Gender,Price,Style,Image,Color,Size")] Shoes shoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(shoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(shoes);
        }

        // GET: Shoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoes = await _context.Shoes.SingleOrDefaultAsync(m => m.Id == id);
            if (shoes == null)
            {
                return NotFound();
            }
            return View(shoes);
        }

        // POST: Shoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Gender,Price,Style,Image,Color,Size")] Shoes shoes)
        {
            if (id != shoes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(shoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ShoesExists(shoes.Id))
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
            return View(shoes);
        }

        // GET: Shoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var shoes = await _context.Shoes
                .SingleOrDefaultAsync(m => m.Id == id);
            if (shoes == null)
            {
                return NotFound();
            }

            return View(shoes);
        }

        // POST: Shoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var shoes = await _context.Shoes.SingleOrDefaultAsync(m => m.Id == id);
            _context.Shoes.Remove(shoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ShoesExists(int id)
        {
            return _context.Shoes.Any(e => e.Id == id);
        }
    }
}
