using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Storage.Model
{
    public class Role:BaseModel
    {
        //角色名称
        public string RoleName { get; set; }
        //这个角色拥有的用户
        public virtual ICollection<User> Users{ get; set; }
    }
}