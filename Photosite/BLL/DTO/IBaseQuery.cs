using MediatR;

namespace Photosite.BLL.DTO
{
    public interface IBaseCommand<TResponse>: IRequest<TResponse>
    {
    }
}
