using Core.DataAccess.Abstract;
using EMarket.Entity.Concrete;

namespace EMarket.DataAccess.Abstract
{
    public interface IProductDal: IEntityRepository<Product>
    {
    }
}
