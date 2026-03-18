using AutoMapper;
using SupplySync.Constants.Enums;
using SupplySync.DTOs.PurchaseOrderAndDelivery;
using SupplySync.Models;
using SupplySync.Repositories.Interfaces;
using SupplySync.Services.Interfaces;

namespace SupplySync.Services
{
    public class PurchaseOrderService : IPurchaseOrderService
    {
        private readonly IPurchaseOrderRepository _repository;
        private readonly IMapper _mapper;

        public PurchaseOrderService(IPurchaseOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }


        public async Task<int> CreatePurchaseOrderAsync(CreatePurchaseOrderDto dto)
        {
            // 1. Map properties from DTO (ContractID, Item, Quantity, Date)
            var po = _mapper.Map<PurchaseOrder>(dto);

            // 2. Set System/Business defaults that aren't in the DTO
            po.Status = POStatus.Draft; // Or whatever your starting status is
            po.CreatedAt = DateTime.UtcNow;
            po.IsDeleted = false;

            // 3. Pass the fully prepared object to the repository
            var created = await _repository.CreatePurchaseOrderAsync(po);
            return created.POID;
        }

        //public async Task<int> CreatePurchaseOrderAsync(CreatePurchaseOrderDto dto)
        //{
        //    var po = _mapper.Map<PurchaseOrder>(dto);
        //    var created = await _repository.CreatePurchaseOrderAsync(po);
        //    return created.POID;
        //}
    }
}