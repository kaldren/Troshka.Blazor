using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Domain.Entities.Region;
using Troshka.Blazor.Domain.Entities.User;
using Troshka.Blazor.Enums;

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
        public DbSet<EngineEntity> Engines { get; set; }
        public DbSet<TransmissionEntity> Transmissions { get; set; }
        public DbSet<CurrencyEntity> Currencies { get; set; }
        public DbSet<EuroStandardEntity> EuroStandards { get; set; }
        public DbSet<MaterialEntity> Materials { get; set; }
        public DbSet<CarOfferEntity> CarOffers { get; set; }
        public DbSet<OfferImageEntity> OfferImages { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        public DbSet<UserCommentsEntity> UserComments { get; set; }

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
                    new CategoryEntity { Id = "0Uun56AGjKNM2f07qMBS", Name = CategoryTypeConstants.Cars },
                    new CategoryEntity { Id = "AhHuT41lRddLH1wachlm", Name = CategoryTypeConstants.Buses },
                    new CategoryEntity { Id = "DARdvjHJcTyGCYGekfIn", Name = CategoryTypeConstants.Motorcycles },
                    new CategoryEntity { Id = "ExCL3LNxUqXNC8LFF8rL", Name = CategoryTypeConstants.Trucks },
                    new CategoryEntity { Id = "GFF7R0xsM4muSxEG8k0J", Name = CategoryTypeConstants.Caravans },
                    new CategoryEntity { Id = "lnm5mTuNV56JTQQYWPRe", Name = CategoryTypeConstants.Boats },
                    new CategoryEntity { Id = "NUSX1N5R2xUS9WfTo3lp", Name = CategoryTypeConstants.Construction },
                    new CategoryEntity { Id = "poo2JeVEhMn8wJz0KJdR", Name = CategoryTypeConstants.Agriciltural }
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

            #region Engines & Transmissions
            modelBuilder
                .AddEngines()
                .AddTransmissions();
            #endregion Engines & Transmissions

            #region Currencies
            modelBuilder
                .AddCurrencies();
            #endregion Currencies

            #region Euro Standards
            modelBuilder
                .AddEuroStandards();
            #endregion Euro Standards

            #region Materials
            modelBuilder
                .AddMaterials();
            #endregion Materials

            #region Offers
            modelBuilder
                .AddCarOffers();
            #endregion Offers

            #region Images
            modelBuilder
                .AddOfferImages();
            #endregion Images

            #region Users
            modelBuilder
                .AddUsers();
            #endregion Users
        }

        private static class SchemaNames
        {
            public const string Troshka = $"{nameof(Troshka)}";
            public const string Cars = $"{nameof(Cars)}";
        }
    }
}