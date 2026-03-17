using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SupplySync.DTOs.Vendor;
using SupplySync.Models;
using SupplySync.Repositories.Interfaces;
using SupplySync.Services.Interfaces;

namespace SupplySync.Services
{
	public class VendorService : IVendorService
	{
		private readonly IVendorRepository _vendorRepository;
		private readonly IMapper _mapper;

		public VendorService(IVendorRepository vendorRepository, IMapper mapper)
		{
			_vendorRepository = vendorRepository;
			_mapper = mapper;
		}

		public async Task<VendorResponseDto> CreateVendor(CreateVendorRequestDto createVendorRequestDto)
		{
			Vendor newVendor = _mapper.Map<Vendor>(createVendorRequestDto);
			// after mapping we will get vendor

			var vendor =  await _vendorRepository.CreateVendor(newVendor);

			// map with response dto
			VendorResponseDto vendorResponseDto = _mapper.Map<VendorResponseDto>(vendor);

			return vendorResponseDto;
		}

		public async Task<VendorDocumentResponseDto> CreateVendorDocument(CreateVendorDocumentRequestDto createVendorDocumentRequestDto)
		{
			VendorDocument newVendorDocument = _mapper.Map<VendorDocument>(createVendorDocumentRequestDto);
			newVendorDocument.FileURI = "fileUrl added";

			var vendorDocument = await _vendorRepository.CreateVendorDocument(newVendorDocument);

			VendorDocumentResponseDto vendorDocumentResponseDto = _mapper.Map<VendorDocumentResponseDto>(vendorDocument);

			return vendorDocumentResponseDto;
		}
	}
}
