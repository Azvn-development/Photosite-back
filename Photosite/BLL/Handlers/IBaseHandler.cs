using MediatR;

namespace Photosite.BLL.Handlers
{
    public interface IBaseHandler<TRequest, TResponse>: IRequestHandler<TRequest, TResponse> where TRequest: IRequest<TResponse>
    {
    }
}
