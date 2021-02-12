﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AppService.Domain.Entities;
using Microsoft.AspNetCore.SignalR;
using AppService.Application.Hubs;

namespace AppService.Application.Services
{
    public sealed class AccessLogNotifier : IAccessLogNotifier
    {
        private readonly IHubContext<AccessLogHub> accessLogHubContext;

        public AccessLogNotifier(IHubContext<AccessLogHub> accessLogHubContext)
        {
            this.accessLogHubContext = accessLogHubContext;
        }

        public async Task NotifyLogAppendedAsync(AccessLogEntry accessLogEntry)
        {
            await accessLogHubContext.Clients.All.SendAsync("LogAppended", accessLogEntry);
        }
    }
}
