namespace NZWalks.API.Models.Domain
{
	public class Walk
	{
		public Guid Id { get; set; }		
		public string Name { get; set; }	
		public double Length { get; set; }
		public Guid RegiondId { get; set; }
		public Guid WalkDiffcultyId { get; set; }

		// NavigationProperty
		public Region Region { get; set; }
		public WalkDiffculty WalkDiffculty { get; set; }
	}
}
