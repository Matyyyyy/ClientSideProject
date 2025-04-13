using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace KratomShop.Models.Database
{
    public class OrderLine
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } = Guid.NewGuid();
        [Required]
        public Item Item { get; set; } = null!;
        public Guid ItemId { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(6,4)")]
        [Required]
        public decimal VatRate { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Order Order { get; set; } = null!;
        public int OrderId { get; set; }
        public decimal PriceIncVat => Price * (1 + VatRate)* Quantity;
    }
}
