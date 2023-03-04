using MediatR;

namespace OnlineAccountingAppServer.Application.Messaging
{
    public interface IQuery<out TResponse> : IRequest<TResponse>
    {
    }
}
