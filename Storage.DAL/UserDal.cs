using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Storage.Model;

namespace Storage.DAL
{
    public class UserDal:BaseDal<User>
    {
        public int Add(User user)
        {
            return base.Add("insert into users values(@username,@password,@name,@phone,@sex,@address,default)", user);
        }

        public int Update(User user)
        {
            return base.Update("update users set name = @name,phone=@phone,address=@address where id=@id", user);
        }

        public int Delete(User user)
        {
            return base.Update("update users set isdel = 1 where id = @id", user);
        }

        public IEnumerable<User> GetSignleUsers()
        {
            return base.GetSignleEntities("select id,username,password,name,phone,sex,address from users where isDel = 0", null);
        } 
    }
}
