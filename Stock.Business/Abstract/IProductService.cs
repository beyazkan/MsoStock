using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        void Add(Product product);
    }
}
