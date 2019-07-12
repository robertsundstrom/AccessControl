﻿using System;

namespace Foobiq.AccessControl.AppService.Domain.Models
{
    public class AccessLogEntry
    {
        public Guid AccessLogEntryId { get; set; }

        public virtual AccessLog AccessLog { get; set; }

        public DateTime Timestamp { get; set; }
        
        public Guid? AccessPointId { get; set; }

        public virtual AccessPoint AccessPoint { get; set; }

        public Guid? IdentityId { get; set; }

        public virtual Identity Identity { get; set; }

        public AccessEvent Event { get; set; }

        public string Message { get; set; }
    }
}
