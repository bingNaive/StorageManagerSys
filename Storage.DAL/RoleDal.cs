using System.Collections.Generic;
using Storage.Model;

namespace Storage.DAL
{
    public class RoleDal:BaseDal<Role>
    {
        public int Add(Role role)
        {
            return base.Add("",role);
        }

        public int Update(Role role)
        {
            return base.Update("", role);
        }

        public int Delete(Role role)
        {
            return base.Update("", role);
        }

        public IEnumerable<Role> GetSignleRoles()
        {
            return base.GetSignleEntities("", null);
        } 
    }
}