using BethanysPieShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Components
{

    public class ShoppinCartSummary: ViewComponent
    {
        private readonly IShoppingCart _shoppingCart;

        public ShoppinCartSummary(IShoppingCart shoppingCart)
        {
            _shoppingCart = shoppingCart;
        }

        public IViewComponentResult Invoke()
        {
            var items = _shoppingCart.GetShoppingCartItems();
            _shoppingCart.ShoppingCartItems = items;

            var shoppingCartViewModek = new ShoppingCartViewModel(_shoppingCart, 
                _shoppingCart.GetShoppingCartTotal());
            
            return View(shoppingCartViewModek);
        }
    }
}
