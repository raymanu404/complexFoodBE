﻿using MediatR;
using Application.DtoModels.Buyer;
using Domain.Models.Roles;

namespace Application.Features.Buyers.Queries.LoginBuyer
{
    public class LoginBuyerQuery: IRequest<BuyerDto>
    {
        public BuyerDtoLogin BuyerLogin { get; set; }       
    }
}
