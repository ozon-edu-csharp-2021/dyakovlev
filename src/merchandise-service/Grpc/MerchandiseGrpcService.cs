﻿using System;
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

        public override Task<EmployeeMerchHistoryResponse> GetEmployeeMerchHistory(EmployeeMerchHistoryRequest request, ServerCallContext context)
        {
            throw new NotImplementedException();
        }
    }
}