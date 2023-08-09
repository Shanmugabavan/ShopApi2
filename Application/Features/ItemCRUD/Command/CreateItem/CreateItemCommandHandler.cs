using AutoMapper;
using MediatR;
using ShopAPI.Application.Contracts.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace ShopAPI.Application.Features.ItemCRUD.Command.CreateItem
{
    public class CreateItemCommandHandler:IRequestHandler<CreateItemCommand,Unit>
    {

        private readonly IItemRepository _item_repository;
        private readonly IMapper _mapper;

        public CreateItemCommandHandler(IItemRepository itemRepository,
             IMapper mapper)
        {
            _item_repository = itemRepository;
            _mapper = mapper;
        }

        public async Task<Unit> Handle(CreateItemCommand request, CancellationToken cancellationToken)
        {
            var item = _mapper.Map<Domain.Item>(request);
            _item_repository.AddItem(item);

            //Assign Allocations IF an allocation doesn't already exist for period and leave type





            return Unit.Value;
        }
    }
}
