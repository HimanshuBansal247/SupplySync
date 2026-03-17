using SupplySync.Config;
using SupplySync.Models;
using SupplySync.Repositories.Interfaces;

namespace SupplySync.Repositories
{
	public class ContractRepository : IContractRepository
	{
		private readonly AppDbContext _appDbContext;
		public ContractRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public async Task<Contract> CreateContract(Contract newContract)
		{
			await _appDbContext.Contracts.AddAsync(newContract);
			await _appDbContext.SaveChangesAsync();
			return newContract;
		}

		public async Task<ContractTerm> CreateContractTerm(ContractTerm newContractTerm)
		{
			await _appDbContext.ContractTerms.AddAsync(newContractTerm);
			await _appDbContext.SaveChangesAsync();
			return newContractTerm;
		}
	}
}
