using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Storage.Model
{
    public class User:BaseModel
    {
        [StringLength(30)]
        [Required]
        public string UserName { get; set; }
        [StringLength(30)]
        [Required]
        public string Password { get; set; }
        [StringLength(20)]
        [Required]
        public string Name { get; set; }
        [StringLength(30)]
        [Required]
        public string Phone { get; set; }
        [Required]
        public int Sex { get; set; }
        //地址
        [StringLength(100)]
        [Required]
        public string Address { get; set; }
        //角色实例
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Action> Actions { get; set; }
        public virtual ICollection<ExportProduct> CusExportProducts { get; set; }
        public virtual ICollection<ExportProduct> HeadExportProducts { get; set; }
    }
}
