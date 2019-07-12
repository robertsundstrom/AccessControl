﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Foobiq.AccessPoint.Services
{
    public interface IRelayControlService : IDisposable
    {
        Task<IEnumerable<RelayInfo>> GetRelaysAsync();
        Task<bool> GetRelayStateAsync(int relay);
        Task SetRelayStateAsync(int relay, bool state);
    }
}
