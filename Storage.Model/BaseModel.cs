using System.ComponentModel.DataAnnotations;

namespace Storage.Model
{
    public class BaseModel
    {
        [Key]
        public int Id { get; set; } 
    }
}