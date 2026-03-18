using SupplySync.Constants.Enums;
using SupplySync.DTOs.PurchaseOrderAndDelivery;
using SupplySync.Models;

namespace SupplySync.Mappers
{
    public partial class MapperProfile
    {
        private void ConfigurePurchaseOrderAndDeliveryMappings()
        {
            // Purchase Order Mappings
            CreateMap<CreatePurchaseOrderDto, PurchaseOrder>().ReverseMap();

            // Delivery Mappings
            CreateMap<CreateDeliveryDto, Delivery>()
                .ForMember(dest => dest.Status, opt => opt.MapFrom(src => ConvertDeliveryStatus(src.Status)));
        }

        private static POStatus ConvertPOStatus(string status)
        {
            return Enum.TryParse<POStatus>(status, true, out var parsed)
                ? parsed
                : POStatus.Draft; // Default value
        }

        private static DeliveryStatus ConvertDeliveryStatus(string status)
        {
            return Enum.TryParse<DeliveryStatus>(status, true, out var parsed)
                ? parsed
                : DeliveryStatus.Shipped; // Default value
        }
    }
}