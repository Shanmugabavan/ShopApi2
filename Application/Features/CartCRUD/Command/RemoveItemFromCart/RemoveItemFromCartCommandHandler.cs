using AutoMapper;
using MediatR;
using ShopAPI.Application.Contracts.Persistence;
using ShopAPI.Application.Features.CartCRUD.Command.AddItemToCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Application.Features.CartCRUD.Command.RemoveItemFromCart
{
    public class RemoveItemFromCartCommandHandler :IRequestHandler<RemoveItemFromCartCommand,Unit>
    {
        private readonly ICartRepository _cart_repository;
        private readonly IItemRepository _item_repository;
        private readonly IMapper _mapper;

        public RemoveItemFromCartCommandHandler(ICartRepository cartRepository, IItemRepository item_repository,
             IMapper mapper)
        {
            _cart_repository = cartRepository;
            _item_repository = item_repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(RemoveItemFromCartCommand request, CancellationToken cancellationToken)
        {
            int cartId = request.CartID;
            int itemId = request.ItemID;
            await _cart_repository.RemoveItemFromCart(itemId, cartId);


            return Unit.Value;
        }
    }
}
