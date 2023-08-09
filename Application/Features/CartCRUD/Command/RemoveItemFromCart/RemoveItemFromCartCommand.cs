using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Application.Features.CartCRUD.Command.RemoveItemFromCart
{
    public class RemoveItemFromCartCommand:IRequest<Unit>
    {
        public RemoveItemFromCartCommand(int itemId,int cartId)
        {
            this.ItemID=itemId;
            this.CartID=cartId;
        }

        public int CartID { get; set; }
        public int ItemID { get; set; }
    }
}
