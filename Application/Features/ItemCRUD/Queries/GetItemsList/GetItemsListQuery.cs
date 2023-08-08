using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;

namespace ShopAPI.Application.Features.ItemCRUD.Queries.GetItemsList
{
    public class GetItemsListQuery : IRequest<List<ItemDto>>
    {

    }
}
