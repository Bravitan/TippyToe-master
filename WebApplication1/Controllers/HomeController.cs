using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TippyToe.Models;

namespace TippyToe.Controllers
{
    public class HomeController : Controller
    {
        private readonly TippyToeContext _context;

        public HomeController(TippyToeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Write your description here...";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact";

            return View();
        }

        public async Task<IActionResult> Men()
        {
            ViewData["Message"] = "Men";

            return View(await _context.Shoes.ToListAsync());
        }
            
        public async Task<IActionResult> Women()
        {
            ViewData["Message"] = "Women";

            return View(await _context.Shoes.ToListAsync());
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
