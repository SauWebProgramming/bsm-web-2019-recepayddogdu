using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProgramlamaOdev.Entity;

namespace WebProgramlamaOdev.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            
            return View(_context.Products.Where(i=>i.IsHome&& i.IsApproved).ToList());

        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id==id).ToList());
        }

        public ActionResult List()
        {
            return View(_context.Products.Where(i => i.IsApproved).ToList());
        }

    }
}