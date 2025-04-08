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
        public virtual Item Item { get; set; } = null!;
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Required]
        public int VatRate { get; set; }
        [Required]
        public int Quantity { get; set; }
        public Order Order { get; set; } = null!;
        public int OrderId { get; set; }
    }
}
