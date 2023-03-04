using MediatR;

namespace OnlineAccountingAppServer.Application.Messaging
{
    public interface ICommand<out TResponse> : IRequest<TResponse>
    {

    }
}
