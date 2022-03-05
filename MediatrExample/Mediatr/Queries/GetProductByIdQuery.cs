using MediatR;

namespace MediatrExample.Mediatr.Queries;

public class GetProductByIdQuery : IRequest<GetProductByIdViewModel>
{
    public Guid Id { get; set; }
}