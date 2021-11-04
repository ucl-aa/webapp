using System.Threading.Tasks;
using WebApp.ViewModels;

namespace WebApp.Repositories
{
    public interface IStatusHistoryRepository
    {
        Task<Delivery> GetStatusHistoryFromTracingId(string tracingId);
    }
}