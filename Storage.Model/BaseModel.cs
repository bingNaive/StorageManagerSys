using System.ComponentModel.DataAnnotations;

namespace Storage.Model
{
    public class BaseModel
    {
        public BaseModel()
        {
            IsDel = false;
        }
        [Key]
        public int Id { get; set; }

        public bool IsDel { get; set; }
    }
}