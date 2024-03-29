﻿using MediatR;
using Application.DtoModels.Buyer;

namespace Application.Features.Buyers.Commands.UpdateBuyer
{
    public class UpdatePasswordBuyerCommand : IRequest<string>
    {
        public int BuyerId { get; set; }
        public BuyerUpdatePasswordDto BuyerUpdatePassword { get; set; }
    }
}
