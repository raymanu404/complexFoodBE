﻿using MediatR;
using Application.DtoModels.Buyer;
using Application.Contracts.Persistence;
using Application.Components;
using Domain.ValueObjects;


namespace Application.Features.Buyers.Commands.UpdateBuyer
{
    public class ChangePasswordBuyerCommandHandler : IRequestHandler<ChangePasswordBuyerCommand,string>
    {
        private readonly IUnitOfWork _unitOfWork;
        public ChangePasswordBuyerCommandHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<string> Handle(ChangePasswordBuyerCommand request, CancellationToken cancellationToken)
        {
            string returnMessage = "";
            var buyer = await _unitOfWork.Buyers.GetByIdAsync(request.BuyerId);
            if (buyer != null)
            {

                var encodeNewPassoword = EncodePassword.ComputeSha256Hash(request.Buyer.Password);
                buyer.Password = new Password(encodeNewPassoword);
                if (buyer.Password.Value.Equals(""))
                {
                    return "Password invalid!";
                }

                await _unitOfWork.CommitAsync(cancellationToken);
                returnMessage = "Password was updated successfully!";

            }
            else
            {
                returnMessage = "Buyer doesn't exists!";
            }

            return returnMessage;
        }
    }
}
