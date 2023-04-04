using Troshka.Blazor.Models.Transmission;

namespace Troshka.Blazor.Services.Transmission
{
    public interface ITransmissionService
    {
        Task<List<TransmissionModel>> GetAll();
    }
}
