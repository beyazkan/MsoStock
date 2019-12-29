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
    public class UsefulTypeManager : IUsefulTypeService
    {
        IUsefulTypeDal _usefulTypeDal;
        public UsefulTypeManager(IUsefulTypeDal usefulType)
        {
            _usefulTypeDal = usefulType;
        }
        public void Add(UsefulType usefulType)
        {
            _usefulTypeDal.Add(usefulType);
        }

        public List<UsefulType> GetAll()
        {
            return _usefulTypeDal.GetAll();
        }
    }
}
