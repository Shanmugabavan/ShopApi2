using ShopAPI.Application.Features.ItemCRUD.Queries.GetItemsList;
using AutoMapper;
using ShopAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Application.MappingProfiles
{
    public class ItemProfile : Profile
    {
        public ItemProfile()
        {
            CreateMap<ItemDto, Item>().ReverseMap();
            CreateMap<Item, ItemDto>();

        }
    }
}
