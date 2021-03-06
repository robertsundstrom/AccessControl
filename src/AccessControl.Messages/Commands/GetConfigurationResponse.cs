﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AccessControl.Messages.Commands
{
    public class GetConfigurationResponse
    {
        public GetConfigurationResponse(TimeSpan accessTime, bool lockOnClose, bool armOnClose)
        {
            AccessTime = accessTime;
            LockOnClose = lockOnClose;
            ArmOnClose = armOnClose;
        }

        public TimeSpan AccessTime { get; }
        public bool LockOnClose { get; }
        public bool ArmOnClose { get; }
    }
}
