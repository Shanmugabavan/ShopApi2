using Microsoft.AspNetCore.Mvc;
using MediatR;
using ShopAPI.Application.Features.ItemCRUD.Queries.GetItemsList;
using ShopAPI.Application.Features.CartCRUD.Command.CreateCart;
using ShopAPI.Application.Features.CartCRUD.Command.AddItemToCart;
using ShopAPI.Application.Features.CartCRUD.Command.RemoveItemFromCart;

namespace ShopAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CartController : ControllerBase
{
    private readonly IMediator _mediator;

    public CartController(IMediator mediator)
    {
        _mediator = mediator;
    }

    // GET: api/<LeaveAllocationsController>
    

    [HttpPost]
    public async Task<ActionResult> Post(CreateCartCommand cartCommand)
    {
        var response = await _mediator.Send(cartCommand);
        return Ok();
    }

    [HttpPost("carts/{cartId}/items/{itemId}")]
    public async Task<IActionResult> AddItemToCart(int itemId, int cartId)
    {
        var command = new AddItemToCartCommand( itemId,cartId );
        await _mediator.Send(command);

        return Ok(); // Or any other appropriate response
    }

    [HttpPost("carts/remove/{cartId}/items/{itemId}")]
    public async Task<IActionResult> RemoveItemFromCart(int itemId, int cartId)
    {
        var command = new RemoveItemFromCartCommand(itemId, cartId);
        await _mediator.Send(command);

        return Ok(); // Or any other appropriate response
    }


}
