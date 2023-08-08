using Microsoft.AspNetCore.Mvc;
using MediatR;
using ShopAPI.Application.Features.ItemCRUD.Queries.GetItemsList;

namespace ShopAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ItemController : ControllerBase
{
    private readonly IMediator _mediator;

    public ItemController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<LeaveAllocationsController>
    [HttpGet]
    public async Task<ActionResult<List<ItemDto>>> Get()
    {
        var leaveAllocations = await _mediator.Send(new GetItemsListQuery());
        return Ok(leaveAllocations);
    }


}
