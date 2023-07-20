using RealEstate.DataAccess.Abstract;
using RealEstate.DataAccess.Concrete;
using RealEstate.DataAccess.Repositories;
using RealEstate.Entities.Concrete;

namespace RealEstate.DataAccess.EntityFramework
{
    public class EfCustomerDal : GenericRepository<Customer>, ICustomerDal
    {
        public EfCustomerDal(Context context) : base(context)
        {
        }
    }
}
