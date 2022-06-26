using MediatR;

namespace Photosite.BLL.DTO
{
    public interface IBaseQuery<TResponse>: IRequest<TResponse>
    {
    }
}
