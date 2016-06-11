using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Model
{
    /// <summary>
    /// 进货
    /// </summary>
    public class IncludeProduct:BaseModel
    {
        //商品id
        public Guid ProId { get; set; }
        public int Count { get; set; }
        public decimal Price { get; set; }
        //供货方
        [ForeignKey("Customer")]
        public int CusId { get; set; }
        //进货时间
        public DateTime IncludeTime { get; set; }
        //负责人
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual Customer Customer{ get; set; }
        public virtual User User { get; set; }
    }
}