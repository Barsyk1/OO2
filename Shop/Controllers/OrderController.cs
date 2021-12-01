using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class OrderController : Controller
    {
        private readonly IAllOrders allorders;
        private readonly ShopCart shopCart;

        public OrderController(IAllOrders allorders, ShopCart shopCart)
        {
            this.allorders = allorders;
            this.shopCart = shopCart;
        }

        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            shopCart.listShopItems = shopCart.getShopitems();

            if (shopCart.listShopItems.Count == 0)
            {
                ModelState.AddModelError("","Ваша корзина пуста");
            }
            if (ModelState.IsValid)
            {
                allorders.createOrder(order);
                return RedirectToAction("Complete");
            }




            return View(order);
        }
        public IActionResult Complete()
        {
            ViewBag.Message = "Заказ оформлен";
            return View();
        }

    }
}
