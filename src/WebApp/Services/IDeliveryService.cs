using System.Threading.Tasks;
using WebApp.ViewModels;

namespace WebApp.Services
{
    public interface IDeliveryService
    {
        Task<Delivery> GetDeliveryAsync(string tracingId);
    }
}