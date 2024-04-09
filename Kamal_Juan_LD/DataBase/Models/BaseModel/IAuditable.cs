namespace Kamal_Juan_LD.DataBase.Models.BaseModel
{
    public interface IAuditable
    {
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}
