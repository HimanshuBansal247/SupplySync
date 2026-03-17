using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SupplySync.Config;
using SupplySync.Models;
using SupplySync.Repositories.Interfaces;

namespace SupplySync.Repositories
{
	public class VendorRepository : IVendorRepository
	{
		private readonly AppDbContext _appDbContext;

		public VendorRepository(AppDbContext appDbContext)
		{
			_appDbContext = appDbContext;
		}

		public  async Task<Vendor?> CreateVendor(Vendor vendor)
		{
			await _appDbContext.Vendors.AddAsync(vendor);
			await _appDbContext.SaveChangesAsync();
			return vendor;
		}

		public async Task<VendorDocument> CreateVendorDocument(VendorDocument newVendorDocument)
		{
			await _appDbContext.VendorDocuments.AddAsync(newVendorDocument);
			await _appDbContext.SaveChangesAsync();
			return newVendorDocument;
		}
	}

}
