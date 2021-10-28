using System;
using MerchandiseService.HttpModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MerchandiseService
{
    [ApiController]
    [Route("/api/v1")]
    [GlobalExceptionFilter]
    public class MerchandiseController : Controller
    {
        [Route("request-merch")]
        [ProducesResponseType(typeof(MerchResponse), StatusCodes.Status200OK)]
        [HttpPost]
        public ActionResult<MerchResponse> RequestMerch(MerchRequest request)
        {
            throw new NotImplementedException();
        }
        
        [Route("check-delivered")]
        [HttpPost]
        public ActionResult<MerchDeliveredResponse> CheckMerchDelivered(MerchDeliveredRequest request)
        {
            throw new NotImplementedException();
        }
    }
}