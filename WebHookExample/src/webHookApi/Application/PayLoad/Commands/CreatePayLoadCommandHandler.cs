using System;
using MediatR;
using webHookApi.Domain.Entities;
using webHookApi.Domain.Entities.Payload;
using webHookApi.Infrastructure.Respositories.Implementation;
using webHookApi.Presentation.Payload.Dto;

namespace webHookApi.Application.PayLoad.Commands
{
	public class CreatePayLoadCommandHandler : IRequestHandler<CreatePayLoadCommand, PayLoadEntity>
	{
        private readonly IPayLoadRepository _payLoadRepository;

        public CreatePayLoadCommandHandler(IPayLoadRepository payLoadRepository)
        {
            _payLoadRepository = payLoadRepository;
        }
      
        public async Task<PayLoadEntity> Handle(CreatePayLoadCommand request, CancellationToken cancellationToken)
        {

            var payLoad = new PayLoadEntity();
            payLoad.Action = request.PayLoadDto.Action;
            payLoad.Issue.Title = request.PayLoadDto.Issue.Title;
            payLoad.Issue.Url = request.PayLoadDto.Issue.Url;
            payLoad.Issue.Number = request.PayLoadDto.Issue.Number;
            payLoad.RepositoryGit.FullName = request.PayLoadDto.RepositoryGit.FullName;
            payLoad.RepositoryGit.Id = request.PayLoadDto.RepositoryGit.Id;
            payLoad.Sender.Id = request.PayLoadDto.Sender.Id;
            payLoad.Sender.Login = request.PayLoadDto.Sender.Login;

            await _payLoadRepository.AddAsync(payLoad);

            return payLoad;
        }
    }
}

