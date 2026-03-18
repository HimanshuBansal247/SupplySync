using Microsoft.AspNetCore.Mvc;
using SupplySync.DTOs.PurchaseOrderAndDelivery;
using SupplySync.Services.Interfaces;

namespace SupplySync.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PurchaseOrderAndDeliveryController : ControllerBase
    {
        private readonly IPurchaseOrderService _poService;

        public PurchaseOrderAndDeliveryController(
            IPurchaseOrderService poService)
        {
            _poService = poService;
        }

        // --- Purchase Order Endpoints ---
        [HttpGet("create")]
        public async Task<IActionResult> CreatePurchaseOrder()
        {
            return Ok(new { Message = "Purchase Order created successfully" });
        }

        [HttpPost("purchase-order/create")]
        public async Task<IActionResult> CreatePurchaseOrder([FromBody] CreatePurchaseOrderDto dto)
        {
            var id = await _poService.CreatePurchaseOrderAsync(dto);
            return Ok(new { Message = "Purchase Order created successfully", PurchaseOrderID = id });
        }

        // --- Delivery Endpoints ---

        //[HttpPost("delivery/create")]
        //public async Task<IActionResult> CreateDelivery([FromBody] CreateDeliveryDto dto)
        //{
        //    var id = await _deliveryService.CreateDeliveryAsync(dto);
        //    return Ok(new { Message = "Delivery created successfully", DeliveryID = id });
        //}
    }
}