using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplySync.DTOs.Vendor;
using SupplySync.Services.Interfaces;

namespace SupplySync.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class VendorController : ControllerBase
	{
		private readonly IVendorService _vendorService;
		public VendorController(IVendorService vendorService) 
		{
			_vendorService = vendorService;
		}

		[HttpPost("")]
		public async Task<IActionResult> CreateVendor([FromBody] CreateVendorRequestDto createVendorRequestDto)
		{
			VendorResponseDto createdVendor = await _vendorService.CreateVendor(createVendorRequestDto);

			return Ok(createdVendor);
		}

		[HttpPost("{vendorId}/documents")]
		public async Task<IActionResult> CreateVendorDocument([FromBody] CreateVendorDocumentRequestDto createVendorDocumentRequestDto)
		{
			VendorDocumentResponseDto createdVendorDocument = await _vendorService.CreateVendorDocument(createVendorDocumentRequestDto);
			return Ok(createdVendorDocument);
		}
	}
}
