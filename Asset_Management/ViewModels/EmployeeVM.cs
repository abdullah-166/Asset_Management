using System.ComponentModel.DataAnnotations;

namespace Asset_Management.ViewModels
{
    public class EmployeeVM
    {
        public Guid EmployeeId { get; set; }

        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Email { get; set; }

        [StringLength(20)]
        public string? Phone { get; set; }

        [StringLength(100)]
        public string? Department { get; set; }

        [StringLength(100)]
        public string? JobTitle { get; set; }

        public bool IsActive { get; set; } = true;
        public AssetVM? AssetVM { get; set; }
        public DistributedAssetVM? DistributedAssetVM { get; set; }
    }
}
