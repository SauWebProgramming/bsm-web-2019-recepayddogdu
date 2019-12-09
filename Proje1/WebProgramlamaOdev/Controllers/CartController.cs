using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebProgramlamaOdev.Models;

namespace WebProgramlamaOdev.Controllers
{
    public class CartController : Controller
    {
        // GET: Cart
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddToCart(int Id)
        {
            return View();
        }

        public Cart GetCart()
        {
            var cart = (Cart) Session["Cart"];
            if (cart == null)
            {
                cart = new Cart();
                Session["Cart"] = cart;
            }

            return cart;

        }
}
}