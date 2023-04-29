using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Configuration;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models;
using Troshka.Blazor.Models.Offer.Car;
using Troshka.Blazor.Models.User;
using Troshka.Blazor.Services.User;

namespace Troshka.Blazor.Services.Offer
{
    public class OfferService : IOfferService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;
        private readonly IUserService _userService;

        public OfferService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper, IUserService userService)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
            _userService = userService;
        }

        public async Task<ResultModel<CarOfferModel?>> CreateCarOfferAsync(CreateCarOfferRequestModel model)
        {
            bool valid = IsCreateCarOfferValid(model);

            if (!valid)
            {
                return new ResultModel<CarOfferModel?>
                {
                    IsSuccess = false,
                    Message = "Неуспешна операция.",
                    Value = null
                };
            }

            try
            {
                using var context = _dbFactory.CreateDbContext();

                var entity = _mapper.Map<CarOfferEntity>(model);

                var user = new CreateUserModel
                {
                    Id = model.AuthorId,
                    Name = model.Name,
                    Email = model.Email
                };

                await _userService.CreateUserAsync(user);

                await context.CarOffers.AddAsync(entity);

                var result = await context.SaveChangesAsync();

                if (result > 0)
                {
                    var response = _mapper.Map<CarOfferModel>(entity);
                    return new ResultModel<CarOfferModel>
                    {
                        IsSuccess = true,
                        Message = "Успешна операция.",
                        Value = response
                    };
                }
                else
                {
                    return new ResultModel<CarOfferModel>
                    {
                        IsSuccess = false,
                        Message = "Неуспешна операция."
                    };
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public async Task<ResultModel<CarOfferModel>> GetCarOfferAsync(string id)
        {
            try
            {
                using var context = _dbFactory.CreateDbContext();

                string customerName = id;
                var query = context.CarOffers
                    .FromSqlRaw("SELECT * FROM [Cars].[CarOffers] WHERE Id = {0}", id);
                var entity = await query.FirstOrDefaultAsync();


                if (entity != null)
                {
                    var response = _mapper.Map<CarOfferModel>(entity);
                    return new ResultModel<CarOfferModel>
                    {
                        IsSuccess = true,
                        Message = "Успешна операция.",
                        Value = response
                    };
                }
                else
                {
                    return new ResultModel<CarOfferModel>
                    {
                        IsSuccess = false,
                        Message = "Неуспешна операция."
                    };
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ResultModel<CarOfferModel>> EditCarOfferAsync(EditCarOfferRequestModel model)
        {
            try
            {
                using var context = _dbFactory.CreateDbContext();
                var old = await context.CarOffers.FirstOrDefaultAsync(p => p.Id == model.Id);

                if (old != null)
                {
                    old = _mapper.Map<CarOfferEntity>(model);

                    context.CarOffers.Update(old);

                    var result = await context.SaveChangesAsync();

                    if (result > 0)
                    {
                        var response = _mapper.Map<CarOfferModel>(old);
                        return new ResultModel<CarOfferModel>
                        {
                            IsSuccess = true,
                            Message = "Успешна операция.",
                            Value = response
                        };
                    }
                    else
                    {
                        return new ResultModel<CarOfferModel>
                        {
                            IsSuccess = false,
                            Message = "Неуспешна операция."
                        };
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        private bool IsCreateCarOfferValid(CreateCarOfferRequestModel model)
        {
            return
                !string.IsNullOrWhiteSpace(model.AuthorId) &&
                !string.IsNullOrWhiteSpace(model.Name) &&
                !string.IsNullOrWhiteSpace(model.Email) &&
                !string.IsNullOrWhiteSpace(model.CoupeId) &&
                !string.IsNullOrWhiteSpace(model.BrandId) &&
                !string.IsNullOrWhiteSpace(model.ModelId) &&
                !string.IsNullOrWhiteSpace(model.EngineId) &&
                !string.IsNullOrWhiteSpace(model.TransmissionId) &&
                !string.IsNullOrWhiteSpace(model.MaterialId) &&
                !string.IsNullOrWhiteSpace(model.RegionId) &&
                !string.IsNullOrWhiteSpace(model.LocationId) &&
                !string.IsNullOrWhiteSpace(model.EuroStandardId) &&
                model.Horsepower >= OfferConstants.CarsMinHorsepower && model.Horsepower <= OfferConstants.CarsMaxHorsepower &&
                model.Mileage >= OfferConstants.CarsMinMileage && model.Mileage <= OfferConstants.CarsMaxMileage &&
                model.Cubics >= OfferConstants.CarsMinCubics && model.Cubics <= OfferConstants.CarsMaxCubics &&
                model.MonthProduced >= 1 && model.MonthProduced <= 12 &&
                model.YearProduced >= OfferConstants.MinYear && model.YearProduced <= OfferConstants.MaxYear &&
                model.Condition >= 1 && model.Condition <= 3;
        }
    }
}
