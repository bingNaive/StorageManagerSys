using System.Collections;
using System.Collections.Generic;

namespace Storage.Model
{
    /// <summary>
    /// 商品属性表
    /// </summary>
    public class Property:BaseModel
    {
        public string Name { get; set; }

        //此属性对应的所有可选值
        public virtual ICollection<ProValue> Values { get; set; }
    }
}