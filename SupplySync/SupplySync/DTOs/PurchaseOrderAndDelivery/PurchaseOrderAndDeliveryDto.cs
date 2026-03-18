using SupplySync.Constants.Enums;

namespace SupplySync.DTOs.PurchaseOrderAndDelivery
{
    public class CreatePurchaseOrderDto
    {
        public int ContractID { get; set; }
        public string Item { get; set; }
        public int Quantity { get; set; }
        public DateTime Date { get; set; }
    }

    public class CreateDeliveryDto
    {
        public int PurchaseOrderID { get; set; }
        public string TrackingNumber { get; set; } = string.Empty;
        public DateOnly ScheduledDate { get; set; }
        public string Status { get; set; } = string.Empty;
    }
}