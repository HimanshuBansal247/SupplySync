using Microsoft.AspNetCore.Mvc;
using SupplySync.DTOs.Vendor;

namespace SupplySync.Services.Interfaces
{
	public interface IVendorService
	{
		Task<VendorResponseDto> CreateVendor(CreateVendorRequestDto createVendorRequestDto);
		Task<VendorDocumentResponseDto> CreateVendorDocument(CreateVendorDocumentRequestDto createVendorDocumentRequestDto);
	}
}
