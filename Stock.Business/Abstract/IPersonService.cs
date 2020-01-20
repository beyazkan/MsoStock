using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Abstract
{
    public interface IPersonService
    {
        List<Person> GetAll();
        void Add(Person person);
        Object GetAllFullName();
    }
}
