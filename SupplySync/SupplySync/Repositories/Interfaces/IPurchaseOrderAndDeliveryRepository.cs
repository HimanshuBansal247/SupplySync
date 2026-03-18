using SupplySync.Models;

namespace SupplySync.Repositories.Interfaces
{
    public interface IPurchaseOrderRepository
    {
        Task<PurchaseOrder> CreatePurchaseOrderAsync(PurchaseOrder po);
    }

}