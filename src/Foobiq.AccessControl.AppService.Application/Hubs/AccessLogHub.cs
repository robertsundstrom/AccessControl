﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;

namespace Foobiq.AccessControl.AppService.Application.Hubs
{
    [Authorize]
    public class AccessLogHub : Hub
    {

    }
}
