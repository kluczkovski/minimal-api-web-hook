using System;
using MediatR;
using webHookApi.Domain.Entities;
using webHookApi.Domain.Entities.Payload;
using webHookApi.Presentation.Payload.Dto;

namespace webHookApi.Application.PayLoad.Commands
{
	public class CreatePayLoadCommand: IRequest<PayLoadEntity>
	{
        public CreatePayLoadCommand(PayLoadDto payloadDto)
        {
            PayLoadDto = payloadDto;
        }

        public PayLoadDto PayLoadDto { get; set; }
	}
}

