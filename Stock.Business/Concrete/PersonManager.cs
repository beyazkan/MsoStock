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
    public class PersonManager : IPersonService
    {
        IPersonDal _personDal;
        public PersonManager(IPersonDal personDal)
        {
            _personDal = personDal;
        }

        public void Add(Person person)
        {
            _personDal.Add(person);
        }

        public List<Person> GetAll()
        {
            return _personDal.GetAll();
        }

        public Object GetAllFullName()
        {
            var query = from item in GetAll()
                        select new { Id = item.Id, FullName = item.Name + " " + item.LastName };
            return query.ToList();
        }
    }
}
