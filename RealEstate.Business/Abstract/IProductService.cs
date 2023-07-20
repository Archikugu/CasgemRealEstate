using RealEstate.Entities.Concrete;

namespace RealEstate.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<Product> TGetProductsWithCategories();
    }
}
