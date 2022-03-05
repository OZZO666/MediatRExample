using MediatR;

namespace MediatrExample.Mediatr.Queries;

public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery,GetProductByIdViewModel>
{
    public Task<GetProductByIdViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
    {
        var viewModel = new GetProductByIdViewModel()
        {
            Id = request.Id,
            Name = "Kitap"
        };
        
        return Task.FromResult(viewModel);
    }
}