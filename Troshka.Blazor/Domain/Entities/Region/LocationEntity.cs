namespace Troshka.Blazor.Domain.Entities.Region
{
    public class LocationEntity : BaseEntity
    {
        public string Name { get; set; }

        public string RegionId { get; set; }
        public virtual RegionEntity Region { get; set; }
    }
}
