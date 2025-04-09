using KratomShop.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;

namespace KratomShop.Models.Database
{
    public class Item
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Description { get; set; } = null!;
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        [Column(TypeName = "decimal(6,4)")]
        public decimal VatRate { get; set; }
        public string ImageUrl { get; set; } = null!;
        [Required]
        public int Stock { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Review> Reviews { get; set; } = new List<Review>();
        public decimal PriceIncVat => Price * (1 + VatRate);
        //Navigation properties
        public virtual ICollection<OrderLine> OrderItems { get; set; } = new List<OrderLine>();
    }
}
