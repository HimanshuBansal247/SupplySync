using SupplySync.Models;

namespace SupplySync.Repositories.Interfaces
{
	public interface IContractRepository
	{
		Task<Contract> CreateContract(Contract newContract);
		Task<ContractTerm> CreateContractTerm(ContractTerm newContractTerm);
	}
}
