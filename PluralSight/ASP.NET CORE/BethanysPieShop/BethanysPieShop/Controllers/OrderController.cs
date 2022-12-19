﻿using BethanysPieShop.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    [Authorize]
    public class OrderController : Controller
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IShoppingCart _shoppingCart;

        public OrderController(IOrderRepository orderRepository, IShoppingCart shoppingCart)
        {
            _orderRepository = orderRepository;
            _shoppingCart = shoppingCart;
        }

        [HttpGet]//Default
        public IActionResult CheckOut()//GET
        {
            return View();
        }

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            if(_shoppingCart.ShoppingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "You cart is empty, add some pies first");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(order);
                _shoppingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
        }

        [HttpGet]
        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage =
                "Thanks for your order. You'll soon enjoy our delicious pies!";
            return View();
        }
    }
}
