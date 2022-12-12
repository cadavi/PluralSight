namespace BethanysPieShop.Models
{
	public class ShoppingCartViewModel
	{
		public IShoppingCart ShoppingCart { get;  }
		public decimal ShoppingCartTotal;

        public ShoppingCartViewModel(IShoppingCart shoppingCart, decimal shoppingCartTotal)
		{
			ShoppingCart = shoppingCart;
            ShoppingCartTotal = shoppingCartTotal;
		}
	}
}
