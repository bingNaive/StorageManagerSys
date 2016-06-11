using System;

namespace Storage.Model
{
    /// <summary>
    /// 利润
    /// </summary>
    public class Profit:BaseModel
    {
        public Guid ProId { get; set; }
        //单个利润
        public decimal SingleProfit { get; set; }
        //总利润
        public decimal TotalProfit { get; set; }
    }
}