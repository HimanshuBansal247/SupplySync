using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SupplySync.DTOs.Contract;
using SupplySync.Services;
using SupplySync.Services.Interfaces;

namespace SupplySync.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ContractController : ControllerBase
	{
		private readonly IContractService _contractService;

		public ContractController(IContractService contractService)
		{
			_contractService = contractService;
		}

		[HttpPost("")]
		public async Task<IActionResult> CreateContract([FromBody] CreateContractRequestDto createContractRequestDto)
		{
			ContractResponseDto contractResponseDto = await _contractService.CreateContract(createContractRequestDto);
			return Ok(contractResponseDto);
		}

		

		[HttpPost("{contractId}/terms")]
		public async Task<IActionResult> CreateContractTerm([FromBody] CreateContractTermRequestDto createContractTermRequestDto)
		{
			ContractTermResponseDto contractTermResponseDto = await _contractService.CreateContractTerm(createContractTermRequestDto);
			return Ok(contractTermResponseDto);
		}
	}
}
