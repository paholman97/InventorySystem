using InventorySystem.Data;
using InventorySystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace InventorySystem.Controllers
{
    public class HomeController : Controller
    {
        private InventoryContext inventoryContext { get; set; }

        public HomeController(InventoryContext inventoryContext)
        {
            this.inventoryContext = inventoryContext;
        }

        public IActionResult Index()
        {
            List<InventoryItem> inventoryItems = inventoryContext.InventoryItems.ToList();

            return View(inventoryItems);
        }

        public IActionResult ItemDetails(int inventoryItemId)
        {
            InventoryItem inventoryItem = inventoryContext.InventoryItems.FirstOrDefault(x => x.InventoryItemID == inventoryItemId);

            return View(inventoryItem);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}