using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public class DeliveryServiceStub : IDeliveryService
    {
        private readonly List<Status> _statuses = new();
        private readonly Delivery _delivery;

        public DeliveryServiceStub()
        {
            Status deployedStatus = new()
            {
                UpdateTime = new DateTime(2021, 10, 29),
                Message = "Package has been deployed"
            };
            
            Status arrivedStatus = new()
            {
                UpdateTime = DateTime.Now,
                Message = "Package has arrived at destination"
            };
            _statuses.Add(deployedStatus);
            _statuses.Add(arrivedStatus);
            _delivery = new Delivery()
            {
                TracingId = "asdasd2233",
                StatusHistory = _statuses
            };

        }
        
        public async Task<Delivery> GetDeliveryAsync(string tracingId)
        {
            return _delivery;
        }
    }
}