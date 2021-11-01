using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public class DeliveryServiceStub : IDeliveryService
    {
        private List<Delivery> _deliveries = new List<Delivery>();
        private Status _deployedStatus;
        private Status _arrivedStatus;
        private Delivery _delivery;

        public DeliveryServiceStub()
        {
            _deployedStatus = new Status()
            {
                UpdateTime = new DateTime(2021, 10, 29),
                Message = "Package has been deployed"
            };
            
            _arrivedStatus = new Status()
            {
                UpdateTime = DateTime.Now,
                Message = "Package has arrived at destination"
            };
        }
        
        public Task<Delivery> GetDeliveryAsync(string tracingId)
        {
            throw new System.NotImplementedException();
        }
    }
}