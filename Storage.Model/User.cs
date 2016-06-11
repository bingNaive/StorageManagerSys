using System.Collections.Generic;

namespace Storage.Model
{
    public class User:BaseModel
    {

        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public int Sex { get; set; }
        //地址
        public string Address { get; set; }
        //角色实例
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<ExportProduct> CusExportProducts { get; set; }
        public virtual ICollection<ExportProduct> HeadExportProducts { get; set; }
    }
}
