using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Domain.Entities.Region;

namespace Troshka.Blazor.Infrastructure.Data
{
    public class TroshkaDbContext : DbContext
    {
        public DbSet<CategoryEntity> Category { get; set; }
        public DbSet<CarBrandEntity> CarBrands { get; set; }
        public DbSet<CarModelEntity> CarModels { get; set; }
        public DbSet<CarCoupeEntity> CarCoupes { get; set; }
        public DbSet<RegionEntity> Regions { get; set; }
        public DbSet<LocationEntity> Locations { get; set; }

        public TroshkaDbContext(DbContextOptions<TroshkaDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Categories
            modelBuilder
                .Entity<CategoryEntity>()
                .ToTable("Categories", schema: SchemaNames.Troshka);

            modelBuilder
                .Entity<CategoryEntity>()
                .HasData(
                    new CategoryEntity { Id = "0Uun56AGjKNM2f07qMBS", Name = "Cars" },
                    new CategoryEntity { Id = "AhHuT41lRddLH1wachlm", Name = "Buses" },
                    new CategoryEntity { Id = "DARdvjHJcTyGCYGekfIn", Name = "Motorcycles" },
                    new CategoryEntity { Id = "ExCL3LNxUqXNC8LFF8rL", Name = "Trucks" },
                    new CategoryEntity { Id = "GFF7R0xsM4muSxEG8k0J", Name = "Caravans" },
                    new CategoryEntity { Id = "lnm5mTuNV56JTQQYWPRe", Name = "Boats" },
                    new CategoryEntity { Id = "NUSX1N5R2xUS9WfTo3lp", Name = "Construction" },
                    new CategoryEntity { Id = "poo2JeVEhMn8wJz0KJdR", Name = "Agriciltural" }
                );
            #endregion Categories

            #region Cars
            modelBuilder
                .AddCarBrands()
                .AddCarModels()
                .AddCarCoupes();
            #endregion Cars

            #region Region & Location
            modelBuilder
                .AddRegions()
                .AddLocations();
            #endregion Region & Location
        }

        private static class SchemaNames
        {
            public const string Troshka = $"{nameof(Troshka)}";
            public const string Cars = $"{nameof(Cars)}";
        }
    }
}