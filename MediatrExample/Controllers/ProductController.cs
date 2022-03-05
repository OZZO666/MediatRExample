using MediatR;
using MediatrExample.Mediatr.Commands;
using MediatrExample.Mediatr.Queries;
using Microsoft.AspNetCore.Mvc;

namespace MediatrExample.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductController : ControllerBase
{
    private readonly IMediator _mediator;
    public ProductController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> Get(Guid id)
    {
        var query = new GetProductByIdQuery() {Id = id};
        return Ok(await _mediator.Send(query));
    }
    [HttpPost]
    public async Task<IActionResult> Post(CreateProductCommand command)
    {
        return Ok(await _mediator.Send(command));
    }
}