using System.Collections.Generic;
using EMarket.Entity.Domain_Models;
using EMarket.WindowsFormUI.Entity;

namespace EMarket.WindowsFormUI.Helper
{
    public static class CartHelper
    {
        public static List<WindowsFormCart> Converter(Cart cart)
        {
            List<WindowsFormCart> windowsFormCarts = new List<WindowsFormCart>();
            foreach (var cartCartItem in cart.CartItems)
            {
                windowsFormCarts.Add(new WindowsFormCart()
                {
                    CategoryId = cartCartItem.Product.CategoryId,
                    Id = cartCartItem.Product.Id,
                    Quantity = cartCartItem.Quantity,
                    UnitPrice = cartCartItem.Product.UnitPrice,
                    ProductName = cartCartItem.Product.ProductName,
                    StockAmount = cartCartItem.Product.StockAmount
                });
                
            }

            return windowsFormCarts;
        }
    }
}
