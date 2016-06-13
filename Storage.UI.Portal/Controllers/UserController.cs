using System.Collections.Generic;
using System.Linq;
using Storage.BLL;
using Storage.Model;

namespace Storage.UI.Portal.Controllers
{
    public class UserController
    {
        public UserController()
        {
            service = new UserService();
        }

        private UserService service;
        public List<User> GetUsers()
        {
            return service.GetSignleEntities().ToList();
        } 
    }
}