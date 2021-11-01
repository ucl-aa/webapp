using WebApp.Inerfaces;
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
        public Delivery GetStatusHistoryFromTracingId(string tracingId)
        {
            _deliveryService.
        }
    }
}