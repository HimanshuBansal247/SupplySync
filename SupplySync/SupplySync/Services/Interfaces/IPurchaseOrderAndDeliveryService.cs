using SupplySync.DTOs.PurchaseOrderAndDelivery;

namespace SupplySync.Services.Interfaces
{
    public interface IPurchaseOrderService
    {
        Task<int> CreatePurchaseOrderAsync(CreatePurchaseOrderDto dto);
    }

}