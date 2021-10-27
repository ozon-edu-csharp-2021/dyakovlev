using System;
using System.Threading.Tasks;
using Grpc.Core;

namespace MerchandiseService.Grpc
{
    public class MerchandiseGrpcService : MerchandiseService.MerchandiseServiceBase
    {
        public override Task<MerchResponse> RequestMerch(MerchRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }

        public override Task<MerchDeliveredResponse> CheckMerchDelivered(MerchDeliveredRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }
    }
}