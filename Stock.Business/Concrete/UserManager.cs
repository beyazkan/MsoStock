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
    public class UserManager : IUserService
    {
        IUserDal _userDal;
        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User user)
        {
            _userDal.Add(user);
        }

        public User Get(string Username)
        {
            return _userDal.Get(p => p.Username == Username);
        }

        public List<User> GetAll()
        {
            return _userDal.GetAll();
        }

        public bool Login(string Username, string Password)
        {
            try
            {
                User user = this.Get(Username);
                if (Username == user.Username && Password == user.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (NullReferenceException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
            
        }
    }
}
