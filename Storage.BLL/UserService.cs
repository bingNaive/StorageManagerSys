using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.DAL;
using Storage.Model;

namespace Storage.BLL
{
    public class UserService
    {
        private UserDal userDal;

        public UserService()
        {
            userDal = new UserDal();
        }

        public bool Add(User user)
        {
            return userDal.Add(user)>0;
        }

        public IEnumerable<User> GetSignleEntities()
        {
            return userDal.GetSignleEntities("",null);
        } 
    }
}
