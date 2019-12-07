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
            var urunler=_context.Products
                .Where(i=>i.IsHome&&i.IsApproved)
                .Select(i=>new ProductModel()
                {
                    Id=i.Id,
                    Name=i.Name.Length > 30 ? i.Name.Substring(0, 27) + "..." : i.Name,
                    Description=i.Description.Length>50?i.Description.Substring(0,47)+"...":i.Description,
                    Price=i.Price,
                    Stock=i.Stock,
                    Image=i.Image ?? "1.jpg",
                    CategoryId=i.CategoryId

            }).ToList();
            return View(urunler);

        }

        private void ToList()
        {
            throw new NotImplementedException();
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i => i.Id==id).FirstOrDefault());
        }

        public ActionResult List()
        {
            var urunler = _context.Products
                .Where(i => i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id = i.Id,
                    Name = i.Name,
                    Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "...." : i.Description,
                    Price = i.Price,
                    Stock = i.Stock,
                    Image = i.Image,
                    CategoryId = i.CategoryId

                }).ToList();
            return View(urunler);
        }

    }

    public class ProductModel
    {
        public ProductModel()
        {
        }

        public int Id { get; internal set; }
        public string Name { get; internal set; }
        public string Description { get; internal set; }
        public double Price { get; internal set; }
        public int Stock { get; internal set; }
        public int CategoryId { get; internal set; }
        public string Image { get; internal set; }
    }
}