using Kamal_Juan_LD.DataBase.Models.BaseModel;

namespace Kamal_Juan_LD.DataBase.Models
{
    public class Slider : BaseEntity, IAuditable
    {
        public string Title { get; set; }
        public DateTime CreatedAt { get ; set ; }
        public DateTime UpdatedAt { get ; set ; }
    }
}
