using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Asset_Management.DataModels
{
    public class Component
    {
        [Key]
        public Guid ComponentId { get; set; } = Guid.NewGuid();

    [Required]
    [StringLength(50)]
    public string ComponentTag { get; set; } = string.Empty;

    [Required]
    [StringLength(100)]
    public string Name { get; set; } = string.Empty;

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

        // Status could be: Available, Reserved, Distributed, etc.
        [Required]
        [StringLength(20)]
        public string Status { get; set; } = "Available";

        // Link to an employee if distributed/reserved to someone
        public Guid? AssignedToEmployeeId { get; set; }

        public DateTime? AssignedAt { get; set; }


    [StringLength(128)]
    public string? QRCodeValue { get; set; }

        public DateTime? QRCodeGeneratedAt { get; set; }

        public int QRCodePrinted { get; set; } = 0;


    public string? Notes { get; set; }

        public bool IsActive { get; set; } = true;
    }
}
