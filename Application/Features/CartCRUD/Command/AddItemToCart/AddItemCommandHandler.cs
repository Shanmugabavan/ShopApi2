using AutoMapper;
using MediatR;
using ShopAPI.Application.Contracts.Persistence;
using ShopAPI.Application.Features.CartCRUD.Command.CreateCart;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAPI.Domain;

namespace ShopAPI.Application.Features.CartCRUD.Command.AddItemToCart
{
    class AddItemToCartCommandHandler : IRequestHandler<AddItemToCartCommand,Unit>
    {
        private readonly ICartRepository _cart_repository;
        private readonly IItemRepository _item_repository;
        private readonly IMapper _mapper;

        public AddItemToCartCommandHandler(ICartRepository cartRepository, IItemRepository item_repository,
             IMapper mapper)
        {
            _cart_repository = cartRepository;
            _item_repository= item_repository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(AddItemToCartCommand request, CancellationToken cancellationToken)
        {
            int cartId = request.CartID;
            int itemId = request.ItemID;
            await _cart_repository.AddItemToCart(itemId, cartId);
            

            return Unit.Value;
        }
    }
}
