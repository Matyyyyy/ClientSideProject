using KratomShop.Data;

namespace KratomShop.Models.Database
{
    public class Review
    {
        public Guid Id { get; set; }
        public string Comment { get; set; } = null!;
        public int Rating { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        // Foreign key to the Item
        public Guid ItemId { get; set; }
        public virtual Item Item { get; set; } = null!;
        // Foreign key to the User
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; } = null!;
    }
}
