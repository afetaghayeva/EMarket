using System.Collections.Generic;
using EMarket.Entity.Concrete;
using EMarket.Entity.Domain_Models;

namespace EMarket.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(short quantity,Product product, Cart cart);
        void DeleteFromCart(Product product, Cart cart);
        void Clear(Cart cart);
        void DeleteOneFromCart(Product product,Cart cart);
        List<CartItem> GetAll(Cart cart);
        void Sell(Cart cart);
    }
}
