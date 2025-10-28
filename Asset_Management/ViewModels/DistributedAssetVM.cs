using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asset_Management.ViewModels
{
    public class DistributedAssetVM
    {
        public Guid DistributedId { get; set; }
        public int AssetId { get; set; }
        public Guid? AssignedToUserId { get; set; }
        public DateTime? AssignedAt { get; set; }
        [StringLength(128)]
        public string? QRCodeValue { get; set; }
        [StringLength(128)]
        public string Status { get; set; } = "Available";
        public DateTime? WarrantyEndDate { get; set; }
        public string? Notes { get; set; }
        public bool IsActive { get; set; } = true;
        public EmployeeVM? EmployeeVM { get; set; }
        public AssetVM? AssetVM { get; set; }
    }
}
