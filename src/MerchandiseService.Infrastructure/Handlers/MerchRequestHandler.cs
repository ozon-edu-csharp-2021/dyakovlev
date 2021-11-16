using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using MerchandiseService.Domain.Events;
using MerchandiseService.Domain.Services;
using MerchandiseService.Infrastructure.Commands;

namespace MerchandiseService.Infrastructure.Handlers
{
    public class MerchRequestHandler : AsyncRequestHandler<MerchRequestCommand>
    {
        private IMerchPackBundler _bundlerService;
        private IMediator _mediator;

        public MerchRequestHandler(IMerchPackBundler bundlerService, IMediator mediator)
        {
            _bundlerService = bundlerService;
            _mediator = mediator;
        }

        protected override async Task Handle(MerchRequestCommand requestCommand, CancellationToken cancellationToken)
        {
            object merchPackEvent;
            if (await CanBundleRequestedMerchPack())
            {
                merchPackEvent = new EmployeeCanAcceptMerchPackEvent
                {
                    MerchPack = requestCommand.RequestedPack,
                    Employee = requestCommand.Employee
                };
            }
            else
            {
                merchPackEvent = new CannotBundleMerchPackEvent
                {
                    MerchPack = requestCommand.RequestedPack,
                    Employee = requestCommand.Employee
                };
            }
            await _mediator.Publish(merchPackEvent, cancellationToken);
            
            Task<bool> CanBundleRequestedMerchPack()
            {
                return _bundlerService.CanBundle(requestCommand.RequestedPack, cancellationToken);
            }
        }
    }
}