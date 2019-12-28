using Stock.DataAccess.Abstract;
using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataAccess.Concrete.EntityFramework
{
    public class EfProductTypeDal: EfEntityRepositoryBase<ProductType, StockContext>, IProductTypeDal
    {
    }
}
