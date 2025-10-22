using Microsoft.AspNetCore.Mvc;
using Asset_Management.Models;
using Asset_Management.ViewModels;
using Microsoft.EntityFrameworkCore;
using Asset_Management.Data;

namespace Asset_Management.Controllers
{
    public class AssetController : Controller
    {
        private readonly ApplicationDbContext _context;
        public AssetController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(AssetVM model){
            if (ModelState.IsValid) {
                var asset = new Asset
                {
                    AssetId = Guid.NewGuid(),
                    AssetTag = model.AssetTag,
                    Name = model.Name,
                    Category = model.Category,
                    Brand = model.Brand,
                    Modell = model.Modell,
                    SerialNumber = model.SerialNumber,
                    PurchaseDate = model.PurchaseDate,
                    PurchaseOrderNo = model.PurchaseOrderNo,
                    Supplier = model.Supplier,
                    PurchasePrice = model.PurchasePrice,
                    WarrantyEndDate = model.WarrantyEndDate,
                    Location = model.Location,
                    Status = model.Status,
                    AssignedToUserId = model.AssignedToUserId,
                    AssignedAt = model.AssignedAt,
                    QRCodeValue = model.QRCodeValue,
                    QRCodeGeneratedAt = model.QRCodeGeneratedAt,
                    QRCodePrinted = model.QRCodePrinted,
                    Notes = model.Notes,
                    IsActive = model.IsActive
                };
                _context.Assets.Add(asset);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(model);
        }
        public async Task <IActionResult> Index(){
            var assets = await _context.Assets.ToListAsync();
            return View(assets);
        }
    }
}
