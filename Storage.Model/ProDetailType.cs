using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Model
{
    public class ProDetailType:BaseModel
    {
        //二级类型名称
        [StringLength(30)]
        [Required]
        public string TypeName { get; set; }
        //一级类型外键
        [ForeignKey("ProType")]
        public int ProTypeId { get; set; }

        public virtual ProType ProType { get; set; }
    }
}