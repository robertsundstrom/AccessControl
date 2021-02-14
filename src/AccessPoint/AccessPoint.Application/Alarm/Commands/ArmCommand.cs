﻿using System;
using System.Threading;
using System.Threading.Tasks;
using AccessControl.Messages.Events;
using AccessPoint.Application.Alarm.Queries;
using AccessPoint.Application.Lock.Commands;
using AccessPoint.Application.Services;
using MediatR;

namespace AccessPoint.Application.Alarm.Commands
{
    public class ArmCommand : IRequest<AlarmStateDto>
    {
        public class ArmCommandHandler : IRequestHandler<ArmCommand, AlarmStateDto>
        {
            private readonly IMediator _mediator;
            private readonly AccessPointState _state;
            private readonly ILEDService _ledService;
            private readonly IRelayControlService _relayControlService;
            private readonly IServiceEventClient _serviceEventClient;

            public ArmCommandHandler(
                IMediator mediator,
                AccessPointState state,
                IRelayControlService relayControlService,
                IServiceEventClient serviceEventClient,
                ILEDService ledService)
            {
                _mediator = mediator;
                _state = state;
                _relayControlService = relayControlService;
                _serviceEventClient = serviceEventClient;
                _ledService = ledService;
            }

            public async Task<AlarmStateDto> Handle(ArmCommand request, CancellationToken cancellationToken)
            {
                if (!_state.Armed)
                {
                    var lockState = await _mediator.Send(new LockCommand());

                    _state.Armed = true;

                    await _serviceEventClient.PublishEvent(new AlarmEvent(AlarmState.Armed));

                    await _ledService.ToggleAllLedsOff();
                }

                return await _mediator.Send(new GetAlarmStateQuery());
            }
        }
    }
}
