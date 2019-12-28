using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Abstract
{
    public interface IProductTypeService
    {
        List<ProductType> GetAll();
        void Add(ProductType productType); 
    }
}
