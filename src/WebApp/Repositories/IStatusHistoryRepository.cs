using WebApp.ViewModels;

namespace WebApp.Repositories
{
    public interface IStatusHistoryRepository
    {
        Delivery GetStatusHistoryFromTracingId(string tracingId);
    }
}