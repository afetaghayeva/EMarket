using System.Collections.Generic;
using System.Linq;
using Core.DataAccess.Abstract;
using Core.Entity.Abstract;

namespace EMarket.Entity.Domain_Models
{
    public class Cart:IDomainModel
    {
        public Cart()
        {
            CartItems=new List<CartItem>();
        }
        public List<CartItem> CartItems { get; set; }

        
        public decimal TotalPrice
        {
            get
            {
                var a= CartItems.Sum(c => c.Product.UnitPrice * c.Quantity);
                return a;
            }
        }
    }
}
