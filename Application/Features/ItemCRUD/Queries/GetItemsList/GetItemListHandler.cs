using ShopAPI.Application.Contracts.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using MediatR;
using ShopAPI.Application.Contracts.Persistence;

namespace ShopAPI.Application.Features.ItemCRUD.Queries.GetItemsList
{
    public class GetItemListHandler : IRequestHandler<GetItemsListQuery, List<ItemDto>>
    {
        private readonly IItemRepository _item_repository;
        private readonly IMapper _mapper;

        public GetItemListHandler(IItemRepository itemRepository,
             IMapper mapper)
        {
            _item_repository = itemRepository;
            _mapper = mapper;
        }

        public async Task<List<ItemDto>> Handle(GetItemsListQuery request, CancellationToken cancellationToken)
        {
            // To Add later
            // - Get records for specific user
            // - Get allocations per employee

            var items = await _item_repository.GetItemsList();
            var allocations = _mapper.Map<List<ItemDto>>(items);

            return allocations;
        }
    }
}
