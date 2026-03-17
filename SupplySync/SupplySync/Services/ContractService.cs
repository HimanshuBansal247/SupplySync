using AutoMapper;
using SupplySync.DTOs.Contract;
using SupplySync.Models;
using SupplySync.Repositories.Interfaces;
using SupplySync.Services.Interfaces;

namespace SupplySync.Services
{
	public class ContractService : IContractService
	{
		private readonly IContractRepository _contractRepository;
		private readonly IMapper _mapper;

		public ContractService(IContractRepository contractRepository, IMapper mapper)
		{
			_contractRepository = contractRepository;
			_mapper = mapper;
		}

		public async Task<ContractResponseDto> CreateContract(CreateContractRequestDto createContractRequestDto)
		{
			Contract newContract = _mapper.Map<Contract>(createContractRequestDto);
			
			Contract contract = await _contractRepository.CreateContract(newContract);

			ContractResponseDto contractResponseDto = _mapper.Map<ContractResponseDto>(contract);

			return contractResponseDto;
		}

		public async Task<ContractTermResponseDto> CreateContractTerm(CreateContractTermRequestDto createContractTermRequestDto)
		{
			ContractTerm newContractTerm = _mapper.Map<ContractTerm>(createContractTermRequestDto);

			ContractTerm contractTerm = await _contractRepository.CreateContractTerm(newContractTerm);

			ContractTermResponseDto contractTermResponseDto = _mapper.Map<ContractTermResponseDto>(contractTerm);
			return contractTermResponseDto;
		}
	}
}
