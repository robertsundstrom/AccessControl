﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace AccessControl.Messages.Commands
{
    public class GetAlarmStateResponse
    {
        public GetAlarmStateResponse()
        {
        }

        public GetAlarmStateResponse(AlarmState alarmState)
        {
            AlarmState = alarmState;
        }

        [JsonConverter(typeof(StringEnumConverter))]
        public AlarmState AlarmState { get; }
    }
}