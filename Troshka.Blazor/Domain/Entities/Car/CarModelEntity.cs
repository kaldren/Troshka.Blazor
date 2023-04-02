namespace Troshka.Blazor.Domain.Entities.Car
{
    public class CarModelEntity : BaseEntity
    {
        public string Name { get; set; }
        public string CarBrandId { get; set; }
        public virtual CarBrandEntity CarBrand { get; set; }
    }
}
