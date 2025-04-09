using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KratomShop.Models.Database
{
    public class Address
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string StreetAddress { get; set; } = null!;
        [Required]
        public string City { get; set; } = null!;
        [Required]
        public string ZipCode { get; set; } = null!;
        public string? TaxId { get; set; }           // IČO / Company ID
        public string? VatId { get; set; }           // DIČ / VAT ID
        [Required]
        public string ContactEmail { get; set; } = null!;
        public string? ContactPhone { get; set; }

    }
}
