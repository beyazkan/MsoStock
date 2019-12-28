using Stock.Business.Abstract;
using Stock.DataAccess.Abstract;
using Stock.DataAccess.Concrete.EntityFramework;
using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Concrete
{
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;
        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public void Add(Location location)
        {
            _locationDal.Add(location);
        }

        public List<Location> GetAll()
        {
            return _locationDal.GetAll();
        }
    }
}
