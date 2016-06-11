using System.Collections;
using System.Collections.Generic;

namespace Storage.Model
{
    public class Action:BaseModel
    {
        //权限编号
        public int ActionNumber { get; set; }
        public string ActionName { get; set; }

        public virtual ICollection<User> Users { get; set; }
    }
}