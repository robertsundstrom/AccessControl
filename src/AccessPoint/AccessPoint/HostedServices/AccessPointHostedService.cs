﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AccessPoint.Application.Services;
using Microsoft.Extensions.Hosting;

namespace AccessPoint.HostedServices
{
    public class AccessPointHostedService : IHostedService, IDisposable
    {
        private IAccessPointService _accessService;

        public AccessPointHostedService(
            IAccessPointService accessService)
        {
            _accessService = accessService;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await _accessService.StartAsync(cancellationToken);
        }

        public async Task StopAsync(CancellationToken cancellationToken)
        {
            await _accessService.StopAsync(cancellationToken);
        }

        public void Dispose()
        {

        }
    }
}
