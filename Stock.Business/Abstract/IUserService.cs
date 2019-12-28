using Stock.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock.Business.Abstract
{
    public interface IUserService
    {
        User Get(string Username);
        Boolean Login(string Username, string Password);
    }
}
