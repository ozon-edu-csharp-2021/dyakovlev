using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using MerchandiseService.Domain.AggregationModels.Employee;
using MerchandiseService.Domain.Services;
using MerchandiseService.Infrastructure.Commands;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using EmployeeMerchHistoryRequest = MerchandiseService.Infrastructure.Commands.EmployeeMerchHistoryRequest;
using EmployeeMerchHistoryResponse = MerchandiseService.HttpModels.EmployeeMerchHistoryResponse;
using MerchPack = MerchandiseService.Domain.AggregationModels.MerchPack.MerchPack;

namespace MerchandiseService
{
    [ApiController]
    [Route("/api/v1")]
    [GlobalExceptionFilter]
    public class MerchandiseController : Controller
    {
        private readonly IRepository<Employee> _employees;
        private readonly IRepository<MerchPack> _merchPacks;
        private readonly IMediator _mediator;

        public MerchandiseController(IRepository<Employee> employees, IMediator mediator, IRepository<MerchPack> merchPacks)
        {
            _employees = employees;
            _mediator = mediator;
            _merchPacks = merchPacks;
        }

        [Route("employee/{employeeId}/merch/{merchPackId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [HttpGet]
        public async Task<ActionResult> RequestMerch(int employeeId, int merchPackId)
        {
            var employee = await _employees.GetById(employeeId);
            var merchPack = await _merchPacks.GetById(merchPackId);
            await _mediator.Send(new MerchRequestCommand
            {
                Employee = employee,
                RequestedPack = merchPack
            });
            return Ok();
        }

        [Route("employee/{employeeId}/merch-history")]
        [HttpGet]
        public async Task<ActionResult<EmployeeMerchHistoryResponse>> GetEmployeeMerchHistory(int employeeId)
        {
            var employee = await _employees.GetById(employeeId);
            var merchHistoryResponse = await _mediator.Send(new EmployeeMerchHistoryRequest
            {
                Employee = employee,
            });
            return Ok(MapToHttpModel(merchHistoryResponse));

            EmployeeMerchHistoryResponse MapToHttpModel(
                Infrastructure.Commands.EmployeeMerchHistoryResponse source)
            {
                return new EmployeeMerchHistoryResponse
                {
                    MerchPacks = source.MerchPacks.Select(merchPack => new HttpModels.MerchPack
                    {
                        MerchItems = merchPack.MerchPackType.Items.Select(merchItem => new HttpModels.MerchItem())
                    })
                };
            }
        }
    }
}