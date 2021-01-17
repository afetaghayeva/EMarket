using Core.Entity;
using Core.Entity.Abstract;

namespace EMarket.Entity.Concrete
{
    public class Category:IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
    }
}
