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
        [Route("employee/{employeeId}/merch/{merchType}")]
        [ProducesResponseType(typeof(MerchResponse), StatusCodes.Status200OK)]
        [HttpGet]
        public ActionResult<MerchResponse> RequestMerch(long employeeId, MerchType merchType)
        {
            throw new NotImplementedException();
        }
        
        [Route("employee/{employeeId}/merch-history")]
        [HttpGet]
        public ActionResult<EmployeeMerchHistoryResponse> GetEmployeeMerchHistory(long employeeId)
        {
            throw new NotImplementedException();
        }
    }
}