﻿namespace LeagueBroadcast.Ingame.Data.LBH.Objectives
{
    public class FrontEndObjective
    {
        public Objective Objective { get; set; }

        public string DurationRemaining { get; set; }

        public int GoldDifference { get; set; }

        public FrontEndObjective()
        {
            Objective = new Objective();
            DurationRemaining = "00:00";
            GoldDifference = 0;
        }
    }
}
