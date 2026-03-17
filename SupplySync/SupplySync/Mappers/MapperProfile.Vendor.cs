using SupplySync.DTOs.Vendor;
using SupplySync.Models;

namespace SupplySync.Mappers
{
	public partial class MapperProfile
	{
		public void ConfigureVendorMappings()
		{
			CreateMap<CreateVendorRequestDto, Vendor>().ReverseMap();
			CreateMap<VendorResponseDto, Vendor>().ReverseMap();

			CreateMap<CreateVendorDocumentRequestDto, VendorDocument>().ReverseMap();
			CreateMap<VendorDocumentResponseDto, VendorDocument>().ReverseMap();
		}
	}
}
