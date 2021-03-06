﻿using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using AppService.Application.Devices;
using AppService.Domain.Entities;
using AppService.Domain.Enums;
using MediatR;

namespace AppService.Application.Alarm.Queries
{
    public class GetAlarmStateQuery : IRequest<AlarmResult>
    {
        [Required]
        public string DeviceId { get; set; }

        public sealed class GetAlarmStateQueryHandler : IRequestHandler<GetAlarmStateQuery, AlarmResult>
        {
            private readonly DeviceController _deviceController;

            public GetAlarmStateQueryHandler(
                DeviceController deviceController)
            {
                _deviceController = deviceController;
            }

            public async Task<AlarmResult> Handle(GetAlarmStateQuery request, CancellationToken cancellationToken)
            {
                return new AlarmResult
                {
                    AlarmState = (await _deviceController.GetState(request.DeviceId)).AlarmState == AccessControl.Messages.Commands.AlarmState.Armed ? AlarmState.Armed : AlarmState.Disarmed
                };
            }
        }
    }
}
