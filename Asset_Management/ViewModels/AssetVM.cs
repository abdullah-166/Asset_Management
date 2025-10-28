using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asset_Management.ViewModels
{
    public class AssetVM
    {
        public Guid AssetId { get; set; }
        [StringLength(50)]
        public string? Category { get; set; }
        [StringLength(100)]
        public string? Name { get; set; }
        [StringLength(50)]
        public string? Brand { get; set; }

        [StringLength(50)]
        public string? Modell { get; set; }

        [StringLength(100)]
        public string? Supplier { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal? PurchasePrice { get; set; }

        public DateTime? WarrantyEndDate { get; set; }

        [StringLength(20)]
        public string Status { get; set; } = "Available";
        public string? Notes { get; set; }

        public bool IsActive { get; set; } = true;
        public DistributedAssetVM? DistributedAssetVM { get; set; }
        public EmployeeVM? EmployeeVM { get; set; }
        public DateTime? PurchaseDate { get; internal set; }
        public string PurchaseOrderNo { get; internal set; }
    }
}
