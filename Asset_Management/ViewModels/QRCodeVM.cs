using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asset_Management.DataModels
{
    public class QRCodeVM
    {
        [Key]
        public Guid QRCodeId { get; set; }
        public Guid AssetId { get; set; }
        [StringLength(128)]
        public string? QRCodeValue { get; set; }
        [Range(1, int.MaxValue)]
        public int Quantity { get; set; } = 1;
        public DateTime GeneratedAt { get; set; } = DateTime.UtcNow;
        public bool IsPrinted { get; set; } = false;
        public string? Notes { get; set; }
    }
}
