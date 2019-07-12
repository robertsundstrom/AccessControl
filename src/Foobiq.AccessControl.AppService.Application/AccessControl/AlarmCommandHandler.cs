﻿using System;
using System.Collections.Generic;
using System.Security.Authentication;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Foobiq.AccessControl.AppService.Application.Services;
using Foobiq.AccessControl.AppService.Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace Foobiq.AccessControl.AppService.Application.AccessControl
{
    public sealed class AlarmCommandHandler : IRequestHandler<ArmCommand, AlarmResult>
    {
        private readonly DeviceController _deviceController;

        public AlarmCommandHandler(
            DeviceController deviceController)
        {
            _deviceController = deviceController;
        }

        public async Task<AlarmResult> Handle(ArmCommand request, CancellationToken cancellationToken)
        {
            await _deviceController.Arm(request.DeviceId);
            return new AlarmResult {
                AlarmState = (await _deviceController.GetState(request.DeviceId)).AlarmState == Commands.AlarmState.Armed ? AlarmState.Armed : AlarmState.Disarmed
            };
        }
    }
}
