using System.Collections.Generic;

namespace WebApp.ViewModels
{
    public class Delivery
    {
        public string TracingId { get; set; }
        public List<Status> StatusHistory { get; set; }
    }
}