using System.Threading.Tasks;
using WebApp.Services;
using WebApp.ViewModels;

namespace WebApp.Repositories
{
    public class StatusHistoryRepository : IStatusHistoryRepository
    {
        private readonly IDeliveryService _deliveryService;
        public StatusHistoryRepository(IDeliveryService deliveryService)
        {
            _deliveryService = deliveryService;
        }
        public async Task<Delivery> GetStatusHistoryFromTracingId(string tracingId)
        {
            return await _deliveryService.GetDeliveryAsync(tracingId);
        }
    }
}