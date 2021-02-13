﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccessControl.Messages.Events
{
    public class AlarmEvent : Event
    {
        public const string EventNameConstant = "AlarmEvent";

        public AlarmEvent(AlarmState alarmState) : base(EventNameConstant)
        {
            AlarmState = alarmState;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public AlarmState AlarmState { get; }
    }
}