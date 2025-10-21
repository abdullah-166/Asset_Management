using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asset_Management.ViewModels
{
    public class AssetVM
    {
        public Guid AssetId { get; set; }

        [StringLength(50)]
        public string? AssetTag { get; set; }

        [StringLength(100)]
        public string? Name { get; set; }

        [StringLength(50)]
        public string? Category { get; set; }

        [StringLength(50)]
        public string? Brand { get; set; }

        [StringLength(50)]
        public string? Model { get; set; }

        [StringLength(100)]
        public string? SerialNumber { get; set; }

        public DateTime? PurchaseDate { get; set; }

        [StringLength(50)]
        public string? PurchaseOrderNo { get; set; }

        [StringLength(100)]
        public string? Supplier { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? PurchasePrice { get; set; }

        public DateTime? WarrantyEndDate { get; set; }

        [StringLength(100)]
        public string? Location { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Available";

        public Guid? AssignedToUserId { get; set; }

        public DateTime? AssignedAt { get; set; }

        [StringLength(128)]
        public string? QRCodeValue { get; set; }

        public DateTime? QRCodeGeneratedAt { get; set; }

        public int QRCodePrinted { get; set; } = 0;

        public string? Notes { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
