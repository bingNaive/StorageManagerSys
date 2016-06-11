using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Storage.Model
{
    /// <summary>
    /// 商品属性表
    /// </summary>
    public class Property:BaseModel
    {
        [StringLength(30)]
        [Required]
        public string Name { get; set; }

        //此属性对应的所有可选值
        public virtual ICollection<ProValue> Values { get; set; }
    }
}