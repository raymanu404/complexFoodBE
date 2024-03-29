﻿using MediatR;
using Application.DtoModels.Buyer;

namespace Application.Features.Buyers.Commands.UpdateBuyer
{
    public class ChangePasswordBuyerCommand : IRequest<string>
    {
        public int BuyerId { get; set; }
        public BuyerChangePasswordDto Buyer { get; set; }
    }
}
