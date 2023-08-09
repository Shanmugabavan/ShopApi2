using Application.Features.OrderCRUD.Commands.CreateOrder;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using ShopAPI.Application.Features.ItemCRUD.Command.CreateItem;
using ShopAPI.Application.Features.OrderCRUD.Commands.CreateOrder;

namespace ShopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IMediator _mediator;

        public OrderController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> Post(CreateOrderCommand orderCommand)
        {
            var response = await _mediator.Send(orderCommand);
            return Ok(response);
        }
    }
}
