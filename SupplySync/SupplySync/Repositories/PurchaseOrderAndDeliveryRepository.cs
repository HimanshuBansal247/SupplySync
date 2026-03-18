using Microsoft.EntityFrameworkCore;
using SupplySync.Models;
using SupplySync.Repositories.Interfaces;
using SupplySync.Config;

namespace SupplySync.Repositories
{
    public class PurchaseOrderRepository : IPurchaseOrderRepository
    {
        private readonly AppDbContext _context;
        public PurchaseOrderRepository(AppDbContext context) => _context = context;

        public async Task<PurchaseOrder> CreatePurchaseOrderAsync(PurchaseOrder po)
        {
            await _context.PurchaseOrders.AddAsync(po);
            await _context.SaveChangesAsync();
            return po;
        }
    }

}