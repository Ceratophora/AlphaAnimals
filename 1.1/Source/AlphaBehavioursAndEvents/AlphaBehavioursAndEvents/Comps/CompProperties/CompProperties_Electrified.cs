﻿using Verse;
using System.Collections.Generic;


namespace AlphaBehavioursAndEvents
{
    public class CompProperties_Electrified : CompProperties
    {

        public int electroRate = 0;
        public int electroRadius = 0;
        public List<string> batteriesToAffect = null;



        public CompProperties_Electrified()
        {
            this.compClass = typeof(CompElectrified);
        }


    }
}