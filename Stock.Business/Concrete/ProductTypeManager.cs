using Stock.Business.Abstract;
using Stock.DataAccess.Abstract;
using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Concrete
{
    public class ProductTypeManager : IProductTypeService
    {
        IProductTypeDal _productTypeDal;
        public ProductTypeManager(IProductTypeDal productTypeDal)
        {
            _productTypeDal = productTypeDal;
        }
        public void Add(ProductType productType)
        {
            _productTypeDal.Add(productType);
        }

        public List<ProductType> GetAll()
        {
            return _productTypeDal.GetAll();
        }
    }
}
