﻿namespace AccessPoint.Application.Services
{
    public class CardData
    {
        public CardData(byte[] uid)
        {
            UID = uid;
        }

        public byte[] UID { get; set; }
    }
}
