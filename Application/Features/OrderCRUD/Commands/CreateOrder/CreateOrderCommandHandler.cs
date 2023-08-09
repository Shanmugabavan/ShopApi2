using AutoMapper;
using MediatR;
using ShopAPI.Application.Contracts.Persistence;
using ShopAPI.Application.Features.ItemCRUD.Command.CreateItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAPI.Domain;
using Application.Features.OrderCRUD.Commands.CreateOrder;

namespace ShopAPI.Application.Features.OrderCRUD.Commands.CreateOrder
{
    public class CreateOrderCommandHandler : IRequestHandler<CreateOrderCommand, Unit>
    {
        private readonly IOrderRepository _order_repository;
        private readonly IItemRepository _item_repository;
        private ICartRepository _cart_repository;
        private readonly IMapper _mapper;

        public CreateOrderCommandHandler(IOrderRepository orderRepository, IItemRepository itemRepository, ICartRepository cart_repository,
             IMapper mapper)
        {
            _item_repository = itemRepository;
            _order_repository = orderRepository;
            _cart_repository = cart_repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = _mapper.Map<Domain.Order>(request);
            _order_repository.CreateOrder(order);

            return Unit.Value;
        }
    }
}
