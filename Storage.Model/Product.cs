using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Storage.Model
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }
        //商品名称
        [StringLength(50)]
        [Required]
        public string Title { get; set; }
        //商品描述
        [StringLength(200)]
        [Required]
        public string Description{ get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        //商品类型id
        [ForeignKey("ProType")]
        public int ProTypeId { get; set; }


        public virtual ProType ProType { get; set; }
    }
}