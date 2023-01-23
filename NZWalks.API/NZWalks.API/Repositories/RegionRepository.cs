using NZWalks.API.Data;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Repositories
{
	public class RegionRepository : IRegionRepository
	{
		private readonly NZWalksDbContext _dbContext
		public RegionRepository(NZWalksDbContext dbContext)
		{
			_dbContext = dbContext;
		}
		public IEnumerable<Region> GetAll()
		{
			return _dbContext.Regions.AsEnumerable();
		}
	}
}
