using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Application.Features.CartCRUD.Command.AddItemToCart
{
    public class AddItemToCartCommand:IRequest<Unit>
    {
        public AddItemToCartCommand(int itemId,int cartId)
        {
            this.CartID= cartId;
            this.ItemID= itemId;
        }
        public int CartID { get; set; }
        public int ItemID { get; set; }
    }
}
