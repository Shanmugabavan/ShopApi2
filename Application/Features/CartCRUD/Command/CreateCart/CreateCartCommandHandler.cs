using AutoMapper;
using MediatR;
using ShopAPI.Application.Contracts.Persistence;
using ShopAPI.Application.Features.ItemCRUD.Command.CreateItem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Application.Features.CartCRUD.Command.CreateCart
{
    public class CreateCartCommandHandler : IRequestHandler<CreateCartCommand, Unit>
    {
        private readonly ICartRepository _cart_repository;
        private readonly IMapper _mapper;

        public CreateCartCommandHandler(ICartRepository cartRepository,
             IMapper mapper)
        {
            _cart_repository = cartRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateCartCommand request, CancellationToken cancellationToken)
        {
            var cart = _mapper.Map<Domain.Cart>(request);
            _cart_repository.CreateCart(cart);

            return Unit.Value;
        }
    }
}
