using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.Domain;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class RegionsController : Controller
	{
		private readonly IRegionRepository _regionRepository;
		public RegionsController(IRegionRepository regionRepository)
		{
			_regionRepository = regionRepository;
		}

		[HttpGet]
		public IActionResult GetAllRegions()
		{
			var regions = _regionRepository.GetAll();

			return Ok(regions);
		}
		
	}
}
