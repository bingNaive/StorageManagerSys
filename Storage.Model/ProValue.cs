using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Model
{
    /// <summary>
    /// 商品属性值表
    /// </summary>
    public class ProValue:BaseModel
    {
        [StringLength(100)]
        [Required]
        public string Value { get; set; }
        //属性Id
        [ForeignKey("Property")]
        public int ProId { get; set; }

        public virtual Property Property { get; set; }
    }
}