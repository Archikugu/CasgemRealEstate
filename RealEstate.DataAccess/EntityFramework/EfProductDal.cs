using Microsoft.EntityFrameworkCore;
using RealEstate.DataAccess.Abstract;
using RealEstate.DataAccess.Concrete;
using RealEstate.DataAccess.Repositories;
using RealEstate.Entities.Concrete;

namespace RealEstate.DataAccess.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(Context context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategories()
        {
            using var contex = new Context();
            return contex.Products.Include(x => x.Category).ToList();
        }
    }
}
