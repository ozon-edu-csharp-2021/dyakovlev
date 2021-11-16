using System.Net.Sockets;

namespace MerchandiseService.HttpModels
{
    public class MerchRequest
    {
        public long EmployeeId { get; set; }
        
        public MerchType MerchType { get; set; }
    }
}