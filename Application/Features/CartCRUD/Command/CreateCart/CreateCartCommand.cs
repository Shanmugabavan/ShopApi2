﻿using MediatR;
using ShopAPI.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopAPI.Application.Features.CartCRUD.Command.CreateCart
{
    public class CreateCartCommand : Cart, IRequest<Unit>
    {

    }
}