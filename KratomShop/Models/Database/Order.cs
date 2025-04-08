using KratomShop.Data;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KratomShop.Models.Database
{
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public int? Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public ApplicationUser? CreatedBy { get; set; }
        public string? CreatedById { get; set; }
        [Required]
        public virtual Adress Adress { get; set; } = null!;
        public Guid AdressId { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Discount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        [Required]
        public decimal TotalPrice { get; set; }
        public ICollection<OrderLine> Lines { get; set; } = new List<OrderLine>();
        [Required]
        public OrderStatus Status { get; set; } = OrderStatus.Pending;



    }

    public enum OrderStatus
    {
        [Description("Pending")]
        Pending = 1,

        [Description("Confirmed")]
        Confirmed = 2,

        [Description("Processing")]
        Processing = 3,

        [Description("Shipped")]
        Shipped = 4,

        //Ready for pickup
        [Description("Ready for pickup")]
        ReadyForPickup = 5,

        [Description("Delivered")]
        Delivered = 6,

        [Description("Cancelled")]
        Cancelled = 7,
    }

}
