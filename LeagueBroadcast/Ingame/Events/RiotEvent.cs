﻿using LeagueBroadcast.Common.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeagueBroadcast.Ingame.Events
{
    public class RiotEvent : LeagueEvent
    {
        public int EventID { get; set; }
        public string EventName
        {
            get { return eventType; }
            set { eventType = value; }
        }
        public double EventTime { get; set; }
        public List<string> Assisters { get; set; }
        public string KillerName { get; set; }
        public string VictimName { get; set; }
        public string Recipient { get; set; }
        public string? InhibKilled { get; set; }
        public string? TurretKilled { get; set; }
        public int? KillStreak { get; set; }
    }
}
