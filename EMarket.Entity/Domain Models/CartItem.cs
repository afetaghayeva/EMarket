using Core.Entity.Abstract;
using EMarket.Entity.Concrete;

namespace EMarket.Entity.Domain_Models
{
    public class CartItem:IDomainModel
    {
        public Product Product { get; set; }
        public short Quantity { get; set; }
    }
}
