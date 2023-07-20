using RealEstate.DataAccess.Abstract;
using RealEstate.DataAccess.Concrete;
using RealEstate.DataAccess.Repositories;
using RealEstate.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealEstate.DataAccess.EntityFramework
{
    public class EfCategorytDal : GenericRepository<Category>, ICategoryDal
    {
        public EfCategorytDal(Context context) : base(context)
        {
        }
    }
}
