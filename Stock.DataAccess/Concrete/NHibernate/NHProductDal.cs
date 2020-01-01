using Stock.DataAccess.Abstract;
using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Stock.DataAccess.Concrete.NHibernate
{
    public class NhProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            List<Product> products = new List<Product>
            {
                new Product{
                Id = 1,
                Name = "Deneme",
                Brand = "Sony",
                Model = "A960",
                Type = 1,
                WorkType = 1,
                Warranty = 3,
                Price = 3000,
                Barcode = "1231asda",
                CreatedDate = DateTime.Now,
                UpdatedDate = DateTime.Now
                }
            };

            return products;
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
