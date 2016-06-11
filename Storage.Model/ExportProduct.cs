using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Model
{
    /// <summary>
    /// 出货
    /// </summary>
    public class ExportProduct:BaseModel
    {
        //商品
        public Guid ProId { get; set; }
        public int Count { get; set; }
        //出货时间
        public DateTime ExportTime { get; set; }
        public decimal Price { get; set; }
        //总价
        public decimal TotalMoney { get; set; }
        //顾客
        [ForeignKey("Customer")]
        public int CusId { get; set; }
        //负责人
        [ForeignKey("Head")]
        public int UserId { get; set; }

        public virtual User Customer { get; set; }
        public virtual User Head { get; set; }
    }
}