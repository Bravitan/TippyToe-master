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

        //Shoes s = new Shoes();
        //[HttpPost]
        //public IActionResult Index(CandidateDetail Details, HttpPostedFileBase File1, HttpPostedFileBase File2)
        //{
        //    if (File1 != null && File1.ContentLength > 0 && File2 != null)
        //    {
        //        Details.BinaryPhoto = new byte[File1.ContentLength]; // file1 to store image in binary formate  
        //        File1.InputStream.Read(Details.BinaryPhoto, 0, File1.ContentLength);
        //        string ImageName = System.IO.Path.GetFileName(File2.FileName); //file2 to store path and url  
        //        string physicalPath = Server.MapPath("~/img/" + ImageName);
        //        // save image in folder  
        //        File2.SaveAs(physicalPath);
        //        // store path in database  
        //        Details.PathPhoto = "img/" + ImageName;
        //        s.CandidateDetails.Add(Details);
        //        s.SaveChanges();
        //        return PartialView("detail");
        //    }
        //    if (File1 != null && File1.ContentLength > 0 && File2 == null)
        //    {
        //        Details.BinaryPhoto = new byte[File1.ContentLength]; // file1 to store image in binary formate  
        //        File1.InputStream.Read(Details.BinaryPhoto, 0, File1.ContentLength);
        //        s.CandidateDetails.Add(Details);
        //        s.SaveChanges();
        //        return PartialView("detail");
        //    }
        //    if (File1 == null && File2 != null)
        //    {
        //        string ImageName = System.IO.Path.GetFileName(File2.FileName); //file2 to store path and url  
        //        string physicalPath = Server.MapPath("~/img/" + ImageName);
        //        // save image in folder  
        //        File2.SaveAs(physicalPath);
        //        Details.PathPhoto = "img/" + ImageName;
        //        s.CandidateDetails.Add(Details);
        //        s.SaveChanges();
        //        return PartialView("detail");
        //    }
        //    else
        //    { //if both file1 and file2 are null then we can store others details without any image  
        //        s.CandidateDetails.Add(Details);
        //        s.SaveChanges();
        //        return PartialView("detail");
        //    }
        //}

      


    }
}
