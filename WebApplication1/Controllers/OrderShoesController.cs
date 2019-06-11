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
    public class OrderShoesController : Controller
    {
        private readonly TippyToeContext _context;

        public OrderShoesController(TippyToeContext context)
        {
            _context = context;
        }

        // GET: OrderShoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrderShoes.ToListAsync());
        }

        // GET: OrderShoes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderShoes = await _context.OrderShoes
                .SingleOrDefaultAsync(m => m.Id == id);
            if (orderShoes == null)
            {
                return NotFound();
            }

            return View(orderShoes);
        }

        // GET: OrderShoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrderShoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Quantity")] OrderShoes orderShoes)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderShoes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderShoes);
        }

        // GET: OrderShoes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderShoes = await _context.OrderShoes.SingleOrDefaultAsync(m => m.Id == id);
            if (orderShoes == null)
            {
                return NotFound();
            }
            return View(orderShoes);
        }

        // POST: OrderShoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Quantity")] OrderShoes orderShoes)
        {
            if (id != orderShoes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderShoes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderShoesExists(orderShoes.Id))
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
            return View(orderShoes);
        }

        // GET: OrderShoes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderShoes = await _context.OrderShoes
                .SingleOrDefaultAsync(m => m.Id == id);
            if (orderShoes == null)
            {
                return NotFound();
            }

            return View(orderShoes);
        }

        // POST: OrderShoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderShoes = await _context.OrderShoes.SingleOrDefaultAsync(m => m.Id == id);
            _context.OrderShoes.Remove(orderShoes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderShoesExists(int id)
        {
            return _context.OrderShoes.Any(e => e.Id == id);
        }
    }
}
