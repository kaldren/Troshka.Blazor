using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Troshka.Blazor.Domain.Entities.Car;
using Troshka.Blazor.Infrastructure.Data;
using Troshka.Blazor.Models;
using Troshka.Blazor.Models.Offer.Car;

namespace Troshka.Blazor.Services.Offer
{
    public class OfferService : IOfferService
    {
        private readonly IDbContextFactory<TroshkaDbContext> _dbFactory;
        private readonly IMapper _mapper;

        public OfferService(IDbContextFactory<TroshkaDbContext> dbFactory, IMapper mapper)
        {
            _dbFactory = dbFactory;
            _mapper = mapper;
        }

        public async Task<ResultModel<CarOfferModel>> CreateCarOfferAsync(CreateCarOfferRequestModel model)
        {
            try
            {
                using var context = _dbFactory.CreateDbContext();

                var entity = _mapper.Map<CarOfferEntity>(model);
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

                var entity = await context.CarOffers.FindAsync(id);

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

        private bool ValidateCreateCarOfferAsync(CreateCarOfferRequestModel model)
        {

            return false;
        }
    }
}
