﻿using MediatR;
using Application.DtoModels.Buyer;

namespace Application.Features.Buyers.Commands.UpdateBuyer;

public class UpdateBuyerCommand : IRequest<int>
{
    public int BuyerId { get; set; }
    public BuyerUpdateDto Buyer { get; set; }

}