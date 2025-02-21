﻿using System.Collections.Generic;

namespace SnapCall
{
    public class HandStrength : IHandStrength
    {
        public HandRanking HandRanking { get; set; }
        // Kickers are processed as underlying enum type of Rank from Card. See Hand.GetStrength 
        public IList<int> Kickers { get; set; }

        // Standard CompareTo implementation. See CompareTo summary (mouseover)
        public int CompareTo(IHandStrength other)
        {
            if (this.HandRanking > other.HandRanking) return 1;
            else if (this.HandRanking < other.HandRanking) return -1;

            for (var i = 0; i < this.Kickers.Count; i++)
            {
                if (this.Kickers[i] > other.Kickers[i]) return 1;
                if (this.Kickers[i] < other.Kickers[i]) return -1;
            }

            return 0;
        }
    }
}
