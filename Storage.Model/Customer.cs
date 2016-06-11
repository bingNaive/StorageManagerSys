namespace Storage.Model
{
    /// <summary>
    /// 顾客
    /// </summary>
    public class Customer:BaseModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        //地址
        public string Address { get; set; }
        //true 顾客 false 供货方
        public bool IsCustomer { get; set; }
    }
}