﻿namespace AccessControl.Messages.Commands
{
    public class GetAlarmStateCommand : Command
    {
        public const string GetAlarmStateCommandConstant = "GetAlarmState";

        public GetAlarmStateCommand() : base(GetAlarmStateCommandConstant)
        {
        }
    }
}
