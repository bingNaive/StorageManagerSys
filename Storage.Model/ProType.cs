using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Storage.Model
{
    public class ProType:BaseModel
    {
        //一级商品名称
        [StringLength(30)]
        [Required]
        public string TypeName { get; set; }

        //该商品下的二级类型
        public virtual ICollection<ProDetailType> ProDetailTypes { get; set; }

    }
}