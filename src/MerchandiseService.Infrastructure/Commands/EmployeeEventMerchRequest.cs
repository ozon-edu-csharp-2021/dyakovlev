using System.Dynamic;
using MediatR;
using CSharpCourse.Core.Lib;
using CSharpCourse.Core.Lib.Events;

namespace MerchandiseService.Infrastructure.Commands
{
    public class EmployeeEventMerchRequest : IRequest
    {
        public NotificationEvent NotificationEvent { get; init; }
    }
}