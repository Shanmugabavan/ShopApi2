using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;
using ShopAPI.Domain;

namespace Application.Features.OrderCRUD.Commands.CreateOrder
{
    public class CreateOrderCommand : Order, IRequest<Unit>
    {

    }
}
